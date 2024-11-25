using ExtraAdvancedMultiTier.Business.Abstractions.Daos;

namespace ExtraAdvancedMultiTier.Business.Abstractions;

public interface IEntityService<TEntity, TKey> : IService
    where TEntity : class, IEntity<TKey>
    where TKey : notnull, IEquatable<TKey> {

    protected abstract IDao<TEntity, TKey> Dao { get; }
    protected abstract IEntityView<TEntity, TKey> View { get; }

    public IEntityView<TEntity, TKey> GetEntityView();

    public T? GetEntityView<T>() where T : class, IEntityView<TEntity, TKey>;

    public List<TEntity> GetAll(bool includeDeleted = false);

    public TEntity? GetById(TKey id, bool includeDeleted = false);

    public TEntity Create(TEntity entity, bool doSaveChanges = true);

    public TEntity Update(TEntity entity, bool doSaveChanges = true);

    public TEntity Delete(TEntity entity, bool doSaveChanges = true, bool softDeletes = true);

}
