using Project_Utilities.Enums;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IEntityView<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : IEquatable<TEntityKey> {

    public DialogResult OpenFor(ViewActionsEnum action, TEntity? entity);

    public TEntity? GetCurrentInstance();

}
