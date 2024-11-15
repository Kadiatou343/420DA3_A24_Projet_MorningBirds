using ExtraAdvancedMultiTier.Business.Services;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractService : IService {
    protected IServiceContainer? Parent { get; set; }

    private bool isStarted = false;


    public event IStartable.StartableEventHandler? Starting;
    public event IStartable.StartableEventHandler? Started;
    public event IStoppable.StoppableEventHandler? Stopping;
    public event IStoppable.StoppableEventHandler? Stopped;


    protected AbstractService(IServiceContainer? parent = null) {
        parent?.RegisterService(this);
        this.Parent = parent;
        this.Started += this.OnStarting;
        this.Stopped += this.OnStopping;
        this.Started += this.OnStarted;
        this.Stopped += this.OnStopped;
    }

    public bool IsStarted() {
        return this.isStarted;
    }

    public bool IsStopped() {
        return !this.isStarted;
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
        this.isStarted = true;
        this.TriggerStartedEvent();
    }

    public virtual void Stop() {
        this.TriggerStoppingEvent();
        this.isStarted = false;
        this.TriggerStoppedEvent();
    }

    public virtual IServiceContainer? GetParent() {
        return this.Parent;
    }

    public virtual T? GetParent<T>() where T : class, IServiceContainer {
        return this.Parent as T;
    }

    private void OnStarting(IStartable startable) {
        this.Parent?.GetService<LoggingService>()?.Info($"{this.GetType().ShortDisplayName()} starting...");
    }

    private void OnStarted(IStartable startable) {
        this.Parent?.GetService<LoggingService>()?.Success($"{this.GetType().ShortDisplayName()} started!");
    }

    private void OnStopping(IStoppable stoppable) {
        this.Parent?.GetService<LoggingService>()?.Info($"{this.GetType().ShortDisplayName()} stopping...");
    }

    private void OnStopped(IStoppable stoppable) {
        this.Parent?.GetService<LoggingService>()?.Success($"{this.GetType().ShortDisplayName()} stopped!");
    }
}
