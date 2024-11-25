namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IService : IStartable, IStoppable {

    public IServiceContainer? GetParent();

    public T? GetParent<T>() where T : class, IServiceContainer;

}
