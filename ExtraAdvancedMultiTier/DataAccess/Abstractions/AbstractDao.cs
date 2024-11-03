using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Abstractions.Daos;

namespace ExtraAdvancedMultiTier.DataAccess.Abstractions;

/// <summary>
/// Classe abstraite avancée de DAO pour les entités de type <typeparamref name="TEntity"/> avec clé de type <typeparamref name="TEntityKey"/>.
/// </summary>
/// <typeparam name="TEntity">Le type de l'entité gérée par le DAO.</typeparam>
/// <typeparam name="TEntityKey">Le type de la clé de l'entité gérée par le DAO.</typeparam>
public abstract class AbstractDao<TEntity, TEntityKey> : IDao<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : notnull, IEquatable<TEntityKey> {

    protected readonly IDataContext Context;

    protected AbstractDao(IDataContext context) {
        this.Context = context;
    }


    public virtual List<TEntity> GetAll(bool includeDeleted = false) {
        return includeDeleted
            ? this.Context.GetDbSet<TEntity>().ToList()
            : this.Context.GetDbSet<TEntity>().Where(entity => includeDeleted || entity.GetDateDeleted() == null).ToList();
    }

    public virtual TEntity? GetById(TEntityKey id, bool includeDeleted = false) {
        return includeDeleted
            ? this.Context.GetDbSet<TEntity>().Where(entity => entity.GetId().Equals(id)).FirstOrDefault()
            : this.Context.GetDbSet<TEntity>().Where(entity => entity.GetId().Equals(id) && (includeDeleted || entity.GetDateDeleted() == null)).ToList().FirstOrDefault();
    }

    public virtual TEntity Create(TEntity instance, bool doSaveChanges = true) {
        _ = this.Context.GetDbSet<TEntity>().Add(instance);
        if (doSaveChanges) {
            _ = this.Context.SaveChanges();
        }
        return instance;
    }

    public virtual TEntity Update(TEntity instance, bool doSaveChanges = true) {
        instance.SetDateModified(DateTime.Now);
        _ = this.Context.GetDbSet<TEntity>().Update(instance);
        if (doSaveChanges) {
            _ = this.Context.SaveChanges();
        }
        return instance;
    }

    public virtual TEntity Delete(TEntity instance, bool doSaveChanges = true, bool softDeletes = true) {
        if (softDeletes) {
            instance.SetDateDeleted(DateTime.Now);
            _ = this.Context.GetDbSet<TEntity>().Update(instance);
        } else {
            _ = this.Context.GetDbSet<TEntity>().Remove(instance);
        }
        if (doSaveChanges) {
            _ = this.Context.SaveChanges();
        }
        return instance;
    }
}
