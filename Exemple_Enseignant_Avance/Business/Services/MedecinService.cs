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

/// <summary>
/// Classe de service avancée pour les médecins.
/// Permet la gestion des entités de type <see cref="Medecin"/>.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractEntityService{TEntity, TEntityKey}"/> avec les types <see cref="Medecin"/> et <see cref="int"/>
/// pour bénéficier des opérations CRUD de base et de l'enregistrement automatique auprès du conteneur de services parent
/// (voir <see cref="IServiceContainer"/>).
/// </remarks>
public class MedecinService : AbstractEntityService<Medecin, int> {

    /// <summary>
    /// Le DAO pour les entités de type Medecin.
    /// </summary>
    public override IMedecinDAO Dao { get; }
    /// <summary>
    /// La fenêtre de gestion des médecins.
    /// </summary>
    public override MedecinView View { get; }

    /// <summary>
    /// Constructeur de MedecinService.
    /// </summary>
    /// <param name="parent">Le conteneur de services parent.</param>
    /// <exception cref="ArgumentException">Si le conteneur de services reçu ne contient pas de DataProviderService.</exception>
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
