using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractFacadeContainer : AbstractServiceContainer, IFacadeContainer {

    public delegate void FacadeContainerEventHandler(IFacadeContainer sender, IFacade facade);
    public event FacadeContainerEventHandler? FacadeRegistered;


    protected readonly Dictionary<Type, IFacade> Facades;

    public AbstractFacadeContainer() : base() {
        this.Facades = new Dictionary<Type, IFacade>();
        this.FacadeRegistered += this.OnFacadeRegistered;
    }

    private void OnFacadeRegistered(IFacadeContainer sender, IFacade facade) {
        this.GetLoggingService().Info($"{facade.GetType().ShortDisplayName()} registered in {sender.GetType().ShortDisplayName()}.");
    }

    protected abstract IFacade GetAppropriateFacade();

    public T GetFacade<T>() where T : class, IFacade {
        return this.Facades.Where(kvp => {
            return kvp.Key == typeof(T);
        }).FirstOrDefault().Value as T ?? throw new Exception($"Cannot retrieve facade of type [{typeof(T)}]: no facade of that type is registered in the facade container.");
    }

    public void RegisterFacade(IFacade facade) {
        if (this.Facades.ContainsKey(facade.GetType())) {
            throw new Exception($"Cannot register facade: dacade of type {facade.GetType()} already registered.");
        }
        this.Facades.Add(facade.GetType(), facade);
        this.FacadeRegistered?.Invoke(this, facade);
    }

    public override void Start() {
        this.TriggerStartingEvent();
        foreach (IService service in this.Services.Values) {
            if (service.IsStopped()) {
                service.Start();
            }
        }
        foreach (IFacade facade in this.Facades.Values) {
            if (facade.IsStopped()) {
                facade.Start();
            }
        }
        this.Is_Started = true;
        this.TriggerStartedEvent();
    }

    public override void Stop() {
        this.TriggerStoppingEvent();
        foreach (IFacade facade in this.Facades.Values) {
            if (facade.IsStarted()) {
                facade.Stop();
            }
        }
        foreach (IService service in this.Services.Values) {
            if (service.IsStarted()) {
                service.Stop();
            }
        }
        this.Is_Started = false;
        this.TriggerStoppedEvent();
    }
}
