using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtraAdvancedMultiTier.Business.Abstractions;

/// <summary>
/// Classe abstraite pour les entités du domaine. Implémente <see cref="IEntity{TIdentifier}"/>.
/// <br></br>
/// Définit des propriétés considérées comme générales que toutes les entités 
/// du domaine devraient posséder:
/// <list type="bullet">
/// <item>Id : <typeparamref name="Tkey"/></item>
/// <item>DateCreated : <see cref="DateTime"/></item>
/// <item>DateModified : <see cref="DateTime"/></item>
/// <item>DateDeleted : <see cref="DateTime"/></item>
/// <item>RowVersion : <see cref="byte"/>[]</item>
/// </list>
/// </summary>
/// <typeparam name="Tkey">Le type de données de l'identifiant de l'entité du domaine.</typeparam>
public abstract class AbstractEntity<Tkey> : IEntity<Tkey> where Tkey : notnull, IEquatable<Tkey> {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Tkey Id { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? DateCreated { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; } = null!;

    /// <summary>
    /// Constructeur protégé utilisé lors de la création de nouvelles instances à partir de données
    /// de l'utilisateur.
    /// </summary>
    protected AbstractEntity() { }

    /// <summary>
    /// Constructeur protégé utilisé lors de la création d'instances à partir de données
    /// provenant d'une base de données. Ce constructeur ne devrait pas être utilisé
    /// en d'autres circonstances.
    /// </summary>
    /// <param name="id">L'identifiant de l'entité.</param>
    /// <param name="dateCreated">La date de création de l'entité.</param>
    /// <param name="dateModified">La date de dernière modification de l'entité.</param>
    /// <param name="dateDeleted">La date de suppression de l'entité.</param>
    /// <param name="rowVersion">Le numéro de version de l'entité.</param>
    protected AbstractEntity(Tkey id,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    /// <summary>
    /// Getter pour <see cref="Id"/>, l'identifiant dans la base de données de l'instance.
    /// </summary>
    /// <remarks>
    /// Le type de l'identifiant <typeparamref name="Tkey"/> doit être spécifié comme paramètre de type
    /// de <see cref="AbstractEntity{TIdentifier}"/> dont héritent les classes du domaine.
    /// </remarks>
    /// <returns>L'identifiant de l'instance.</returns>
    public Tkey GetId() {
        return this.Id;
    }

    /// <summary>
    /// Getter pour <see cref="DateCreated"/>, la date de création dans la base de données de l'instance.
    /// </summary>
    /// <returns>La date de création de l'instance ou <see langword="null"/>.</returns>
    public DateTime? GetDateCreated() {
        return this.DateCreated;
    }


    /// <summary>
    /// Getter pour <see cref="DateModified"/>, la date de dernière modification dans la base de données de l'instance.
    /// </summary>
    /// <returns>La date de dernière modification de l'instance ou <see langword="null"/>.</returns>
    public DateTime? GetDateModified() {
        return this.DateModified;
    }

    /// <summary>
    /// Setter pour <see cref="DateModified"/>, la date de dernière modification dans la base de données de l'instance.
    /// </summary>
    /// <param name="dateModified">La date de dernière modification à setter.</param>
    public void SetDateModified(DateTime dateModified) {
        this.DateModified = dateModified;
    }

    /// <summary>
    /// Getter pour <see cref="DateDeleted"/>, la date de suppression dans la base de données de l'instance.
    /// </summary>
    /// <returns>La date de suppression de l'instance ou <see langword="null"/>.</returns>
    public DateTime? GetDateDeleted() {
        return this.DateDeleted;
    }

    /// <summary>
    /// Setter pour <see cref="DateDeleted"/>, la date de suppression dans la base de données de l'instance.
    /// </summary>
    /// <param name="deletionDate">La date de suppression à setter ou <see langword="null"/>.</param>
    public void SetDateDeleted(DateTime? deletionDate) {
        this.DateDeleted = deletionDate;
    }

    /// <summary>
    /// Retourne <see langword="true"/> si l'instance est considérée comme supprimée dans la base de données.
    /// </summary>
    /// <remarks>
    /// Une instance est considérée supprimée lorsqu'elle possède une valeur non-<see langword="null"/> pour
    /// sa propriété de date de suppression <see cref="DateDeleted"/>.
    /// </remarks>
    /// <returns><see langword="true"/> si l'instance est considérée comme supprimée, <see langword="false"/> sinon.</returns>
    public bool IsDeleted() {
        return this.DateDeleted != null;
    }
}
