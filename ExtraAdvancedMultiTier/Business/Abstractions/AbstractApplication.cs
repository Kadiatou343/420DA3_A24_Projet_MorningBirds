using ExtraAdvancedMultiTier.Business.Domain;
using ExtraAdvancedMultiTier.Business.Services;
using ExtraAdvancedMultiTier.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractApplication : AbstractDefaultExceptionHandler, IApplication, IServiceContainer {
    protected readonly Dictionary<Type, IService> Services;
    public readonly AppConfigurations Configurations;
    public readonly List<string> CliArguments;

    public event IStartable.StartableEventHandler? Starting;
    public event IStartable.StartableEventHandler? Started;
    public event IStoppable.StoppableEventHandler? Stopping;
    public event IStoppable.StoppableEventHandler? Stopped;

    protected AbstractApplication(string[]? args = null) : base() { 
        this.Configurations = AppConfigurationsService.GetConfigs();
        this.CliArguments = args?.ToList() ?? new List<string>();
        this.Services = new Dictionary<Type, IService>();
        this.Started += this.OnStarting;
        this.Stopped += this.OnStopping;
        this.Started += this.OnStarted;
        this.Stopped += this.OnStopped;
    }

    public AppConfigurations GetAppConfigurations() {
        return this.Configurations;
    }

    // TODO: @PROF Move service method implementations to a future abstract class for that (AbstractServiceContainer)

    public virtual T GetService<T>() where T : class, IService {
        return this.Services.Where(service => {
            return service.GetType() == typeof(T);
        }) as T ?? throw new Exception($"Cannot retrieve service of type [{typeof(T)}]: no service of that type is registered in the service container.");
    }

    public virtual void RegisterService(IService service) {
        if (this.Services.ContainsKey(service.GetType())) {
            throw new Exception($"Cannot register service: service of type {service.GetType()} already registered.");
        }
        this.Services.Add(service.GetType(), service);
    }

    public virtual void Start() {
        this.TriggerStartingEvent();
        foreach (IService service in this.Services.Values) { 
            service.Start();
        }
        this.TriggerStartedEvent();
    }

    public virtual void Stop() {
        this.TriggerStoppingEvent();
        foreach (IService service in this.Services.Values) {
            service.Stop();
        }
        this.TriggerStoppedEvent();
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

    private void OnStarting(IStartable startable) {
        // TODO: @TEACHER Logging after logging system implementation
    }

    private void OnStarted(IStartable startable) {
        // TODO: @TEACHER Logging after logging system implementation
    }

    private void OnStopping(IStoppable stoppable) {
        // TODO: @TEACHER Logging after logging system implementation
    }

    private void OnStopped(IStoppable stoppable) {
        // TODO: @TEACHER Logging after logging system implementation
    }
}
