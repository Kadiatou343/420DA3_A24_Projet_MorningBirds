using ExtraAdvancedMultiTier.Business.Abstractions.Daos;
using Project_Utilities.Enums;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractEntityService<TEntity, TEntityKey> : AbstractService, IEntityService<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : notnull, IEquatable<TEntityKey> {

    public abstract IDao<TEntity, TEntityKey> Dao { get; }
    public abstract IEntityView<TEntity, TEntityKey> View { get; }

    protected AbstractEntityService(IServiceContainer parent)
        : base(parent) { }


    public virtual TEntity? OpenViewFor(ViewActionsEnum action, TEntity? entity) {
        _ = this.View.OpenFor(action, entity);
        return entity;
    }


    public virtual List<TEntity> GetAll(bool includeDeleted = false) {
        return this.Dao.GetAll(includeDeleted);
    }

    public virtual TEntity? GetById(TEntityKey id, bool includeDeleted = false) {
        return this.Dao.GetById(id, includeDeleted);
    }

    public virtual TEntity Create(TEntity entity, bool doSaveChanges = true) {
        return this.Dao.Create(entity, doSaveChanges);
    }

    public virtual TEntity Update(TEntity entity, bool doSaveChanges = true) {
        return this.Dao.Update(entity, doSaveChanges);
    }

    public virtual TEntity Delete(TEntity entity, bool doSaveChanges = true, bool softDeletes = true) {
        return this.Dao.Delete(entity, doSaveChanges, softDeletes);
    }

    public IEntityView<TEntity, TEntityKey> GetEntityView() {
        return this.View;
    }

    public T? GetEntityView<T>() where T : class, IEntityView<TEntity, TEntityKey> {
        return this.GetEntityView() as T;
    }
}
