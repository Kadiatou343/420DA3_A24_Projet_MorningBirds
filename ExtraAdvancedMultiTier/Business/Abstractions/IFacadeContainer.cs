namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IFacadeContainer : IExceptionHandler, IStartable, IStoppable {

    public T GetFacade<T>() where T : class, IFacade;

    public void RegisterFacade(IFacade facade);

}
