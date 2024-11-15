using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Domain;
using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.DataAccess.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Exemple_Enseignant_Avance.DataAccess.Daos;

/// <summary>
/// Classe DAO avancée pour les médecins.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDao{TEntity, TId}"/> pour bénéficier des opérations CRUD de base.
/// Implémente <see cref="IMedecinDAO"/> pour être supporté par les <see cref="IDataProvider"/>.
/// </remarks>
internal class MedecinDAO : AbstractDao<Medecin, int>, IMedecinDAO {

    /// <summary>
    /// Constructeur du DAO.
    /// </summary>
    /// <param name="context">Une instance de contexte EF Core héritant de <see cref="IDataContext"/>.</param>
    public MedecinDAO(IDataContext context) : base(context) { }


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
    /// Recherche des médecins par nom, prénom ou numéro de license médicale.<br/>
    /// Retourne la liste des médecins dont le nom, le prénom ou le numéro de license médicale contient la valeur de <paramref name="criterion"/>.
    /// </summary>
    /// <param name="criterion">Le critère de recherche.</param>
    /// <param name="withRendezVous">Option pour inclure ou non les rendez-vous du médecin.</param>
    /// <param name="includeDeleted">Option pour inclure ou non les médecins supprimés.</param>
    /// <returns>La liste des médecins trouvés.</returns>
    public List<Medecin> Search(string criterion, bool withRendezVous = false, bool includeDeleted = false) {
        IQueryable<Medecin> query = this.Context.GetDbSet<Medecin>().Where(doc =>
            (
                doc.Nom.Contains(criterion)
                || doc.Prenom.Contains(criterion)
                || doc.NumLicenseMedicale.ToString().Contains(criterion)
            )
            && (includeDeleted || doc.DateDeleted == null)
        );
        if (withRendezVous) {
            query = query.Include(medecin => medecin.RendezVous);
        }
        return query.ToList();
    }
}
