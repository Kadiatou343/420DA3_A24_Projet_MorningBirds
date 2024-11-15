namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IServiceContainer : IExceptionHandler, IStartable, IStoppable {

    public T GetService<T>() where T : class, IService;

    public void RegisterService(IService service);

}
