using Microsoft.EntityFrameworkCore;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IDataContext {

    public DbSet<TEntity> GetDbSet<TEntity>() where TEntity : class;

    public int SaveChanges();

}
