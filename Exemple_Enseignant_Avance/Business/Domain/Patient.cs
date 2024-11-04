using ExtraAdvancedMultiTier.Business.Abstractions;

namespace Exemple_Enseignant_Avance.Business.Domain;

/// <summary>
/// Classe avancée représentant un patient.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractEntity{TId}"/> pour bénéficier de l'identifiant et des méta-données de base.
/// </remarks>
public class Patient : AbstractEntity<int> {
    /// <summary>
    /// Longueur maximale du prénom du patient.
    /// </summary>
    public const int FIRSTNAME_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du nom de famille du patient.
    /// </summary>
    public const int LASTNAME_MAX_LENGTH = 64;
    /// <summary>
    /// Longueur maximale du numéro d'assurance maladie du patient.
    /// </summary>
    public const int ASSNUMBER_MAX_LENGTH = 12;


    private string nom = null!;
    private string prenom = null!;
    private string numAssMaladie = null!;

    // Propriétés des patients

    // NOTE: 'Id' est déjà défini dans AbstractEntity

    public string Nom {
        get { return this.nom; }
        set {
            if (value.Length > LASTNAME_MAX_LENGTH) {
                throw new ArgumentException($"Le nom du patient ne peut pas dépasser {LASTNAME_MAX_LENGTH} caractères.");
            }
            this.nom = value;
        }
    }
    public string Prenom {
        get { return this.prenom; }
        set {
            if (value.Length > FIRSTNAME_MAX_LENGTH) {
                throw new ArgumentException($"Le prénom du patient ne peut pas dépasser {FIRSTNAME_MAX_LENGTH} caractères.");
            }
            this.prenom = value;
        }
    }
    public string NumAssMaladie {
        get { return this.numAssMaladie; }
        set {
            if (value.Length > ASSNUMBER_MAX_LENGTH) {
                throw new ArgumentException($"Le numéro dd'assurance maladie du patient ne peut pas dépasser {ASSNUMBER_MAX_LENGTH} caractères.");
            }
            this.numAssMaladie = value;
        }
    }

    // NOTE: 'DateCreated', 'DateModified', 'DateDeleted' et 'RowVersion' sont déjà définis dans AbstractEntity


    // Propriétés de navigation EF Core
    // Ici l'inverse du Patient / PatientId dans RendezVous

    /// <summary>
    /// Les rendez-vous de ce patient.
    /// </summary>
    public virtual List<RendezVous> RendezVous { get; set; } = new List<RendezVous>();


    /// <summary>
    /// Constructeur orienté création manuelle.
    /// </summary>
    /// <param name="nom">Le nom de famille du patient.</param>
    /// <param name="prenom">Le prénom du patient.</param>
    /// <param name="numAssMaladie">Le numéro d'assurance maladie du patient.</param>
    public Patient(string nom, string prenom, string numAssMaladie) : base() {
        this.Nom = nom;
        this.Prenom = prenom;
        this.NumAssMaladie = numAssMaladie;
    }


    /// <summary>
    /// Constructeur orienté entity framework.
    /// </summary>
    /// <param name="id">L'identifiant du patient.</param>
    /// <param name="nom">Le nom de famille du patient.</param>
    /// <param name="prenom">Le prénom du patient.</param>
    /// <param name="numAssMaladie">Le numéro d'assurance maladie du patient.</param>
    /// <param name="dateCreated">La date de création du patient.</param>
    /// <param name="dateModified">La date de dernière modification du patient.</param>
    /// <param name="dateDeleted">La date de suppression du patient.</param>
    /// <param name="rowVersion">Valeur anti-concurrence ge la base de données.</param>
    protected Patient(
        int id,
        string nom,
        string prenom,
        string numAssMaladie,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(nom, prenom, numAssMaladie) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    /// <summary>
    /// Override de la méthode ToString pour afficher les informations du patient.
    /// </summary>
    /// <returns>Un string représentant le patient.</returns>
    public override string ToString() {
        return $"#{this.Id} - {this.Nom}, {this.Prenom} - {this.NumAssMaladie}";
    }

}
