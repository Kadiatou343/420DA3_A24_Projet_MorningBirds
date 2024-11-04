using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.DataAccess.Contexts;
using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.DataAccess.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Exemple_Enseignant_Avance.DataAccess.Daos;

/// <summary>
/// Classe DAO avancée pour les rendez-vous.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDao{TEntity, TId}"/> pour bénéficier des opérations CRUD de base.
/// Implémente <see cref="IMedecinDAO"/> pour être supporté par les <see cref="IDataProvider"/>.
/// </remarks>
internal class RendezVousDAO : AbstractDao<RendezVous, int>, IRendezVousDAO {

    /// <summary>
    /// Constructeur du DAO.
    /// </summary>
    /// <param name="context">Une instance de contexte EF Core héritant de <see cref="IDataContext"/>.</param>
    public RendezVousDAO(IDataContext context) : base(context) { }


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
    /// Recherche des rendez-vous par identifiant, nom/prénom du patient et nom/prénom du médecin.<br/>
    /// Retourne la liste des rendez-vous dont l'identifiant', le nom/prénom du patient ou le nom/prénom du médecin
    /// contient la valeur de <paramref name="criterion"/>.
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted">Option pour inclure ou non les rendez-vous supprimés.</param>
    /// <returns></returns>
    public List<RendezVous> Search(string criterion, bool includeDeleted = false) {
        return this.Context.GetDbSet<RendezVous>()
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv => (
                    rdv.Id.ToString().Contains(criterion)
                    || rdv.Patient.Nom.Contains(criterion)
                    || rdv.Patient.Prenom.Contains(criterion)
                    || rdv.Medecin.Nom.Contains(criterion)
                    || rdv.Medecin.Prenom.Contains(criterion))
                    && (includeDeleted || rdv.DateDeleted == null)
                )
            .ToList();
    }

    /// <summary>
    /// Retourne la liste des rendez-vous associés à un patient.
    /// </summary>
    /// <param name="patient">Le patient.</param>
    /// <param name="includePastRdvs">Option pour inclure les rendez-vous dont la date est passée ou non.</param>
    /// <param name="includeDeleted">Option pour inclure ou non les rendez-vous supprimés.</param>
    /// <returns></returns>
    public List<RendezVous> GetByPatient(Patient patient, bool includePastRdvs = false, bool includeDeleted = false) {
        return this.Context.GetDbSet<RendezVous>()
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv =>
                    rdv.Patient.Id == patient.Id
                    && (includePastRdvs || DateTime.Compare(rdv.DateRendezVous, DateTime.Now) >= 0)
                    && (includeDeleted || rdv.DateDeleted == null)
                )
            .ToList();
    }

    /// <summary>
    /// Retourne la liste des rendez-vous associés à un médecin.
    /// </summary>
    /// <param name="medecin">Le médecin</param>
    /// <param name="includePastRdvs">Option pour inclure les rendez-vous dont la date est passée ou non.</param>
    /// <param name="includeDeleted">Option pour inclure ou non les rendez-vous supprimés.</param>
    /// <returns></returns>
    public List<RendezVous> GetByMedecin(Medecin medecin, bool includePastRdvs = false, bool includeDeleted = false) {
        return this.Context.GetDbSet<RendezVous>()
            .Include(rdv => rdv.Patient)
            .Include(rdv => rdv.Medecin)
            .Where(
                rdv =>
                    rdv.Medecin.Id == medecin.Id
                    && (includePastRdvs || DateTime.Compare(rdv.DateRendezVous, DateTime.Now) >= 0)
                    && (includeDeleted || rdv.DateDeleted == null)
                )
            .ToList();
    }

}
