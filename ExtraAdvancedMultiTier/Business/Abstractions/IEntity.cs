namespace ExtraAdvancedMultiTier.Business.Abstractions;

/// <summary>
/// Interface pour les entités du domaine.
/// <br></br>
/// Elle force la définition de méthodes d'accès pour certaines propriétés 
/// considérées générales que toutes les entités du domaine devraient posséder:
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Id</item>
/// <item>DateCreated</item>
/// <item>DateModified</item>
/// <item>DateDeleted</item>
/// </list>
/// </remarks>
/// <typeparam name="Tkey">Le type de données de l'identifiant de l'entité du domaine.</typeparam>
public interface IEntity<Tkey> where Tkey : notnull, IEquatable<Tkey> {

    /// <summary>
    /// Getter pour l'identifiant dans la base de données de l'instance.
    /// </summary>
    /// <returns>L'identifiant de l'instance ou <see langword="null"/>.</returns>
    public Tkey GetId();

    /// <summary>
    /// Getter pour la date de création l'instance dans la base de données de.
    /// </summary>
    /// <returns>La date de création de l'instance ou <see langword="null"/>.</returns>
    DateTime? GetDateCreated();

    /// <summary>
    /// Getter pour la date de dernière modification de l'instance dans la base de données.
    /// </summary>
    /// <returns>La date de dernière modification de l'instance ou <see langword="null"/>.</returns>
    DateTime? GetDateModified();

    /// <summary>
    /// Setter pour <see cref="DateModified"/>, la date de dernière modification dans la base de données de l'instance.
    /// </summary>
    /// <param name="dateModified">La date de dernière modification à setter.</param>
    public void SetDateModified(DateTime dateModified);

    /// <summary>
    /// Getter pour la date de suppression de l'instance dans la base de données.
    /// </summary>
    /// <returns>La date de suppression de l'instance ou <see langword="null"/>.</returns>
    DateTime? GetDateDeleted();

    /// <summary>
    /// Setter pour la date de suppression dans la base de données
    /// </summary>
    /// <param name="deletionDate">La date de suppression à setter ou <see langword="null"/>.</param>
    void SetDateDeleted(DateTime? deletionDate);

    /// <summary>
    /// Retourne <see langword="true"/> si l'instance est considérée comme supprimée dans la base de données.
    /// </summary>
    /// <remarks>
    /// Une instance est considérée supprimée lorsqu'elle possède une valeur non-<see langword="null"/> pour
    /// sa propriété de date de suppression.
    /// </remarks>
    /// <returns><see langword="true"/> si l'instance est considérée comme supprimée, <see langword="false"/> sinon.</returns>
    bool IsDeleted();

}
