using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.Presentation.Views;
using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Abstractions.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.Business.Services;
public class MedecinService : AbstractEntityService<Medecin, int> {

    public override IMedecinDAO Dao { get; }
    public override MedecinView View { get; }

    public MedecinService(IServiceContainer parent) : base(parent) {
        this.Dao = parent.GetService<DataProviderService>()?.GetDataProvider()?.GetMedecinDao()
            ?? throw new ArgumentException("Le conteneur de services parent reçu n'a pas de DataProviderService enregistré.", nameof(parent));
        this.View = new MedecinView(parent);
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
    /// Recherche des médecins par nom, prénom ou numéro de numéro de license médicale.
    /// </summary>
    /// <param name="criterion">Le critère de recherche.</param>
    /// <param name="withRendezVous">option pour inclure ou non les rendez-vous du médecin.</param>
    /// <param name="includeDeleted">Option pour inclure ou non les médecins supprimés.</param>
    /// <returns></returns>
    public List<Medecin> Search(string criterion, bool withRendezVous = false, bool includeDeleted = false) {
        return this.Dao.Search(criterion, withRendezVous, includeDeleted);
    }

}
