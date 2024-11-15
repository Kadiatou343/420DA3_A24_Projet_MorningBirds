namespace ExtraAdvancedMultiTier.Business.Abstractions;
public class AbstractFacade : AbstractServiceContainer, IFacade {

    public event IStartable.StartableEventHandler? Starting;
    public event IStartable.StartableEventHandler? Started;
    public event IStoppable.StoppableEventHandler? Stopping;
    public event IStoppable.StoppableEventHandler? Stopped;

    protected readonly IFacadeContainer Parent;
    protected readonly IView MainView;


    public AbstractFacade(IFacadeContainer parent) : base() {
        this.Parent = parent;
        this.Parent.RegisterFacade(this);
    }

    public IFacadeContainer? GetParent() {
        return this.Parent;
    }

    T? IFacade.GetParent<T>() where T : class {
        throw new NotImplementedException();
    }

    T IServiceContainer.GetService<T>() {
        throw new NotImplementedException();
    }

    public IView GetMainView() {
        return this.MainView;
    }

    public T? GetMainView<T>() where T : class, IView {
        return this.GetMainView() as T;
    }
}
