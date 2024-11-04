using ExtraAdvancedMultiTier.Business.Abstractions;

namespace Exemple_Enseignant_Avance.Business.Domain;

/// <summary>
/// Classe avancée représentant un médecin.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractEntity{TId}"/> pour bénéficier de l'identifiant et des méta-données de base.
/// </remarks>
public class Medecin : AbstractEntity<int> {
    public const int FIRSTNAME_MAX_LENGTH = 64;
    public const int LASTNAME_MAX_LENGTH = 64;
    public const int LICENSE_MAX_LENGTH = 16;


    private string nom = null!;
    private string prenom = null!;
    private string numLicenseMedicale = null!;

    // Propriétés des médecins

    // NOTE: 'Id' est déjà défini dans AbstractEntity

    public string Nom {
        get { return this.nom; }
        set {
            if (value.Length > LASTNAME_MAX_LENGTH) {
                throw new ArgumentException($"Le nom du médecin ne peut pas dépasser {LASTNAME_MAX_LENGTH} caractères.");
            }
            this.nom = value;
        }
    }
    public string Prenom {
        get { return this.prenom; }
        set {
            if (value.Length > FIRSTNAME_MAX_LENGTH) {
                throw new ArgumentException($"Le prénom du médecin ne peut pas dépasser {FIRSTNAME_MAX_LENGTH} caractères.");
            }
            this.prenom = value;
        }
    }
    public string NumLicenseMedicale {
        get { return this.numLicenseMedicale; }
        set {
            if (value.Length > LICENSE_MAX_LENGTH) {
                throw new ArgumentException($"Le numéro de license médicale du médecin ne peut pas dépasser {LICENSE_MAX_LENGTH} caractères.");
            }
            this.numLicenseMedicale = value;
        }
    }

    // NOTE: 'DateCreated', 'DateModified', 'DateDeleted' et 'RowVersion' sont déjà définis dans AbstractEntity


    // Propriétés de navigation EF Core
    // Ici l'inverse du Medecin / MedecinId dans RendezVous
    public virtual List<RendezVous> RendezVous { get; set; } = new List<RendezVous>();


    /// <summary>
    /// constructeur orienté création manuelle.
    /// </summary>
    /// <param name="nom">Le nom de famille du médecin.</param>
    /// <param name="prenom">Le prénom du médecin.</param>
    /// <param name="numLicenseMedicale">Le numéro de license médicale du médecin.</param>
    public Medecin(string nom, string prenom, string numLicenseMedicale) {
        this.Nom = nom;
        this.Prenom = prenom;
        this.NumLicenseMedicale = numLicenseMedicale;
    }

    /// <summary>
    /// constructeur orienté création par Entity Framework.
    /// </summary>
    /// <param name="id">L'identifiant du médecin.</param>
    /// <param name="nom">Le nom de famille du médecin.</param>
    /// <param name="prenom">Le prénom du médecin.</param>
    /// <param name="numLicenseMedicale">Le numéro de license médicale du médecin.</param>
    /// <param name="dateCreated">La date de création du médecin.</param>
    /// <param name="dateModified">La date de dernière modification du médecin.</param>
    /// <param name="dateDeleted">La date de suppression du médecin.</param>
    /// <param name="rowVersion">Valeur anti-concurrence ge la base de données.</param>
    protected Medecin(
        int id,
        string nom,
        string prenom,
        string numLicenseMedicale,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(nom, prenom, numLicenseMedicale) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    /// <summary>
    /// Override de la méthode ToString pour afficher les informations du médecin.
    /// </summary>
    /// <returns>Un string représentant le médecin.</returns>
    public override string ToString() {
        return $"#{this.Id} - {this.Nom}, {this.Prenom} - {this.NumLicenseMedicale}";
    }

}
