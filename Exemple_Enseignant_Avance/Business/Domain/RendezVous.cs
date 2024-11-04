using ExtraAdvancedMultiTier.Business.Abstractions;

namespace Exemple_Enseignant_Avance.Business.Domain;

/// <summary>
/// Classe avancée représentant un rendez-vous.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractEntity{TId}"/> pour bénéficier de l'identifiant et des méta-données de base.
/// </remarks>
public class RendezVous : AbstractEntity<int> {

    // Propriétés des rendez-vous

    // NOTE: 'Id' est déjà défini dans AbstractEntity

    public DateTime DateRendezVous { get; set; }
    public int PatientId { get; set; }
    public int MedecinId { get; set; }

    // NOTE: 'DateCreated', 'DateModified', 'DateDeleted' et 'RowVersion' sont déjà définis dans AbstractEntity


    // Propriétés de navigation EF Core

    /// <summary>
    /// Le patient associé à ce rendez-vous.
    /// </summary>
    public virtual Patient Patient { get; set; } = null!;
    /// <summary>
    /// Le médecin associé à ce rendez-vous.
    /// </summary>
    public virtual Medecin Medecin { get; set; } = null!;



    /// <summary>
    /// Constructeur orienté création manuelle.
    /// </summary>
    /// <param name="dateRendezVous">La date du rendez-vous.</param>
    /// <param name="patientId">L'identifiant du patient associé au rendez-vous.</param>
    /// <param name="medecinId">L'identifiant du médecin associé au rendez-vous.</param>
    public RendezVous(DateTime dateRendezVous, int patientId, int medecinId) {
        this.DateRendezVous = dateRendezVous;
        this.PatientId = patientId;
        this.MedecinId = medecinId;
    }


    /// <summary>
    /// Constructeur orienté entity framework.
    /// </summary>
    /// <param name="id">L'identifiant du rendez-vous.</param>
    /// <param name="dateRendezVous">La date du rendez-vous.</param>
    /// <param name="patientId">L'identifiant du patient associé au rendez-vous.</param>
    /// <param name="medecinId">L'identifiant du médecin associé au rendez-vous.</param>
    /// <param name="dateCreated">La date de création du rendez-vous.</param>
    /// <param name="dateModified">La date de dernière modification du rendez-vous.</param>
    /// <param name="dateDeleted">La date de suppression du rendez-vous.</param>
    /// <param name="rowVersion">Valeur anti-concurrence ge la base de données.</param>
    protected RendezVous(int id,
        DateTime dateRendezVous,
        int patientId,
        int medecinId,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)

        : this(dateRendezVous, patientId, medecinId) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    /// <summary>
    /// Override de la méthode ToString pour afficher les informations du rendez-vous.
    /// </summary>
    /// <returns>Un string représentant le rendez-vous.</returns>
    public override string ToString() {
        return $"#{this.Id} le {this.DateRendezVous:dd MMM yyyy à HH:mm} - {this.Patient.Nom}, {this.Patient.Prenom} avec Dr. {this.Medecin.Nom}";
    }
}
