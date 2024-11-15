using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.Presentation.Views;
using ExtraAdvancedMultiTier.Business.Abstractions;

namespace Exemple_Enseignant_Avance.Business.Services;

/// <summary>
/// Classe de service avancée pour les patients.
/// Permet la gestion des entités de type <see cref="Patient"/>.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractEntityService{TEntity, TEntityKey}"/> avec les types <see cref="Patient"/> et <see cref="int"/>
/// pour bénéficier des opérations CRUD de base et de l'enregistrement automatique auprès du conteneur de services parent
/// (voir <see cref="IServiceContainer"/>).
/// </remarks>
public class PatientService : AbstractEntityService<Patient, int>, IEntityService<Patient, int> {

    /// <summary>
    /// Le DAO pour les entités de type Patient.
    /// </summary>
    public override IPatientDAO Dao { get; }
    /// <summary>
    /// La fenêtre de gestion des patients.
    /// </summary>
    public override PatientView View { get; }

    /// <summary>
    /// Constructeur de PatientService.
    /// </summary>
    /// <param name="parent">Le conteneur de services parent.</param>
    /// <exception cref="ArgumentException">Si le conteneur de services reçu ne contient pas de DataProviderService.</exception>
    public PatientService(IServiceContainer parent)
        : base(parent) {
        this.Dao = parent.GetService<DataProviderService>()?.GetDataProvider()?.GetPatientDao()
            ?? throw new ArgumentException("Le conteneur de services parent reçu n'a pas de DataProviderService enregistré.", nameof(parent));
        this.View = new PatientView(parent);
    }


    /*
     * NOTE: Les méthodes suivantes sont automatiquement héritées de AbstractEntityService<TEntity, TEntityKey>:
     * - OpenViewFor(ViewActionsEnum, TEntity)  (virtual -> peut être redéfinie)
     * - GetAll(bool)                           (virtual -> peut être redéfinie)
     * - GetById(int, bool)                     (virtual -> peut être redéfinie)
     * - Create(TEntity, bool)                  (virtual -> peut être redéfinie)
     * - Update(TEntity, bool)                  (virtual -> peut être redéfinie)
     * - Delete(TEntity, bool, bool)            (virtual -> peut être redéfinie)
     */


    /// <summary>
    /// Recherche des patients par nom, prénom ou numéro de numéro d'assurance maladie.
    /// </summary>
    /// <param name="criterion">Le critère de recherche.</param>
    /// <param name="withRendezVous">option pour inclure ou non les rendez-vous du patient.</param>
    /// <param name="includeDeleted">Option pour inclure ou non les patients supprimés.</param>
    /// <returns></returns>
    public List<Patient> Search(string criterion, bool withRendezVous = false, bool includeDeleted = false) {
        return this.Dao.Search(criterion, withRendezVous, includeDeleted);
    }

}
