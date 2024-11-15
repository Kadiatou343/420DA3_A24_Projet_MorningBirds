using ExtraAdvancedMultiTier.Business.Services;
using ExtraAdvancedMultiTier.Presentation;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractServiceContainer : AbstractDefaultExceptionHandler, IServiceContainer, ILoggingServiceContainer {

    public delegate void ServiceContainerEventHandler(IServiceContainer sender, IService service);
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

    public LoggingService GetLoggingService() {
        return this.GetService<LoggingService>();
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
        this.TriggerStartingEvent();
        foreach (IService service in this.Services.Values) {
            if (service.IsStopped()) {
                service.Start();
            }
        }
        this.Is_Started = true;
        this.TriggerStartedEvent();
    }

    public virtual void Stop() {
        this.TriggerStoppingEvent();
        foreach (IService service in this.Services.Values) {
            if (service.IsStarted()) {
                service.Stop();
            }
        }
        this.Is_Started = false;
        this.TriggerStoppedEvent();
    }

    public bool IsStarted() {
        return this.Is_Started;
    }

    public bool IsStopped() {
        return !this.Is_Started;
    }

    protected virtual void OnStarting(IStartable startable) {
        this.GetLoggingService().Info($"{this.GetType().ShortDisplayName()} starting...");
    }

    protected virtual void OnStarted(IStartable startable) {
        this.GetLoggingService().Success($"{this.GetType().ShortDisplayName()} started!");
    }

    protected virtual void OnStopping(IStoppable stoppable) {
        this.GetLoggingService().Info($"{this.GetType().ShortDisplayName()} stopping...");
    }

    protected virtual void OnStopped(IStoppable stoppable) {
        this.GetLoggingService().Success($"{this.GetType().ShortDisplayName()} stopped!");
    }

    private void OnServiceRegistered(IServiceContainer sender, IService service) {
        this.GetLoggingService().Info($"{service.GetType().ShortDisplayName()} registered in {sender.GetType().ShortDisplayName()}.");
    }
}
