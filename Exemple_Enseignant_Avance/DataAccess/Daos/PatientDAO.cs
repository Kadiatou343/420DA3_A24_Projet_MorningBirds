using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Domain;
using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.DataAccess.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Exemple_Enseignant_Avance.DataAccess.Daos;

/// <summary>
/// Classe DAO avancée pour les patients.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDao{TEntity, TId}"/> pour bénéficier des opérations CRUD de base.
/// Implémente <see cref="IMedecinDAO"/> pour être supporté par les <see cref="IDataProvider"/>.
/// </remarks>
internal class PatientDAO : AbstractDao<Patient, int>, IPatientDAO {

    /// <summary>
    /// Constructeur du DAO.
    /// </summary>
    /// <param name="context">Une instance de contexte EF Core héritant de <see cref="IDataContext"/>.</param>
    public PatientDAO(IDataContext context) : base(context) { }


    /*
     * NOTE: Les méthodes CRUD de base sont déjà implémentées dans AbstractDao<T, TId>.
     * Incluant:
     *      + GetAll()
     *      + GetById(TId id)
     *      + Create(TEntity entity)
     *      + Insert(TEntity entity)
     *      + Update(TEntity entity)
     *      + Delete(TEntity entity)
     */


    /// <summary>
    /// Recherche des patients par nom, prénom ou numéro de numéro d'assurance maladie.<br/>
    /// Retourne la liste des médecins dont le nom, le prénom ou le numéro d'assurance maladie' contient la valeur de <paramref name="criterion"/>.
    /// </summary>
    /// <param name="criterion">Le critère de recherche.</param>
    /// <param name="withRendezVous">option pour inclure ou non les rendez-vous du patient.</param>
    /// <param name="includeDeleted">Option pour inclure ou non les patients supprimés.</param>
    /// <returns>La liste des patients trouvés.</returns>
    public List<Patient> Search(string criterion, bool withRendezVous = false, bool includeDeleted = false) {
        IQueryable<Patient> query = this.Context.GetDbSet<Patient>().Where(
            patient => (
                patient.Nom.Contains(criterion)
                || patient.Prenom.Contains(criterion)
                || patient.NumAssMaladie.Contains(criterion)
            )
            && (includeDeleted || patient.DateDeleted == null)
        );
        if (withRendezVous) {
            query = query.Include(patient => patient.RendezVous);
        }
        return query.ToList();
    }

}
