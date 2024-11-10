using ExtraAdvancedMultiTier.Business.Services;
using ExtraAdvancedMultiTier.Presentation;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractServiceContainer : AbstractDefaultExceptionHandler, IServiceContainer {

    public delegate void ServiceContainerEventHandler(IServiceContainer sender, IService? service = null);
    public event ServiceContainerEventHandler? ServiceRegistered;

    public event IStartable.StartableEventHandler? Starting;
    public event IStartable.StartableEventHandler? Started;
    public event IStoppable.StoppableEventHandler? Stopping;
    public event IStoppable.StoppableEventHandler? Stopped;

    protected readonly Dictionary<Type, IService> Services;
    protected bool Is_Started = false;

    protected AbstractServiceContainer() {
        this.Services = new Dictionary<Type, IService>();
        this.Started += this.OnStarting;
        this.Stopped += this.OnStopping;
        this.Started += this.OnStarted;
        this.Stopped += this.OnStopped;
        this.ServiceRegistered += this.OnServiceRegistered;
    }

    public virtual T GetService<T>() where T : class, IService {
        return this.Services.Where(kvp => {
            return kvp.Key == typeof(T);
        }).FirstOrDefault().Value as T ?? throw new Exception($"Cannot retrieve service of type [{typeof(T)}]: no service of that type is registered in the service container.");
        
    }

    public virtual void RegisterService(IService service) {
        if (this.Services.ContainsKey(service.GetType())) {
            throw new Exception($"Cannot register service: service of type {service.GetType()} already registered.");
        }
        this.Services.Add(service.GetType(), service);
        this.ServiceRegistered?.Invoke(this, service);
    }

    protected void TriggerStartingEvent() {
        this.Starting?.Invoke(this);
    }

    protected void TriggerStartedEvent() {
        this.Started?.Invoke(this);
    }

    protected void TriggerStoppingEvent() {
        this.Stopping?.Invoke(this);
    }

    protected void TriggerStoppedEvent() {
        this.Stopped?.Invoke(this);
    }

    public virtual void Start() {
        this.GetService<LoggingService>()?.Info("Application starting...");
        this.TriggerStartingEvent();
        foreach (IService service in this.Services.Values) {
            service.Start();
        }
        this.Is_Started = true;
        this.TriggerStartedEvent();
        this.GetService<LoggingService>()?.Success("Application started!");
    }

    public virtual void Stop() {
        this.GetService<LoggingService>()?.Info("Application stopping...");
        this.TriggerStoppingEvent();
        foreach (IService service in this.Services.Values) {
            service.Stop();
        }
        this.Is_Started = false;
        this.TriggerStoppedEvent();
        this.GetService<LoggingService>()?.Success("Application stopped!");
    }

    public bool IsStarted() {
        return this.Is_Started;
    }

    public bool IsStopped() {
        return !this.Is_Started;
    }

    private void OnStarting(IStartable startable) {
        this.GetService<LoggingService>()?.Info($"{this.GetType().ShortDisplayName()} starting...");
    }

    private void OnStarted(IStartable startable) {
        this.GetService<LoggingService>()?.Success($"{this.GetType().ShortDisplayName()} started!");
    }

    private void OnStopping(IStoppable stoppable) {
        this.GetService<LoggingService>()?.Info($"{this.GetType().ShortDisplayName()} stopping...");
    }

    private void OnStopped(IStoppable stoppable) {
        this.GetService<LoggingService>()?.Success($"{this.GetType().ShortDisplayName()} stopped!");
    }

    public virtual void OnServiceRegistered(IServiceContainer sender, IService? service = null) {

    }
}
