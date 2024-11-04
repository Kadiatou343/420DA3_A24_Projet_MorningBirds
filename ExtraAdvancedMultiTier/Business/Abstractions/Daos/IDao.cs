namespace ExtraAdvancedMultiTier.Business.Abstractions.Daos;

/// <summary>
/// Interface avancée de DAO (Data Access Object) pour les entités de type <typeparamref name="TEntity"/> avec clé de type <typeparamref name="TEntityKey"/>.
/// </summary>
/// <typeparam name="TEntity">Le type de l'entité gérée par le DAO.</typeparam>
/// <typeparam name="TEntityKey">Le type de la clé de l'entité gérée par le DAO.</typeparam>
public interface IDao<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : IEquatable<TEntityKey> {


    /// <summary>
    /// Déclaration de méthode généralisée de requête globale pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <returns>La <see cref="List{T}">liste</see> des instances de <typeparamref name="TEntity"/> existantes</returns>
    public List<TEntity> GetAll(bool includeDeleted = false);

    /// <summary>
    /// Déclaration de méthode généralisée de requête par identifiant pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <param name="id">L'identifiant de l'instance à obtenir</param>
    /// <returns>L'instance de <typeparamref name="TEntity"/> obtenue ou <see langword="null"/> si aucune ne correspond</returns>
    public TEntity? GetById(TEntityKey id, bool includeDeleted = false);

    /// <summary>
    /// Déclaration de méthode généralisée d'insertion pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="TEntity"/> à insérer</param>
    /// <param name="doSaveChanges">Option pour enregistrer immédiatement les changements ou non. Défault <see langword="true"/>.</param>
    /// <returns>L'instance de <typeparamref name="TEntity"/> insérée</returns>
    public TEntity Create(TEntity instance, bool doSaveChanges = true);

    /// <summary>
    /// Déclaration de méthode généralisée de mise à jour pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="TEntity"/> à mettre à jour</param>
    /// <param name="doSaveChanges">Option pour enregistrer immédiatement les changements ou non. Défault <see langword="true"/>.</param>
    /// <returns>L'instance de <typeparamref name="TEntity"/> mise à jour</returns>
    public TEntity Update(TEntity instance, bool doSaveChanges = true);


    /// <summary>
    /// Déclaration de méthode généralisée de suppression pour <typeparamref name="TEntity"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="TEntity"/> à supprimer</param>
    /// <param name="doSaveChanges">Option pour enregistrer immédiatement les changements ou non.</param>
    /// <param name="softDeletes">Si la suppression doit utiliser le système de soft deletes. Défault <see langword="true"/>.</param>
    /// <returns>L'instance de <typeparamref name="TEntity"/> supprimée</returns>
    public TEntity Delete(TEntity instance, bool doSaveChanges = true, bool softDeletes = true);

}
