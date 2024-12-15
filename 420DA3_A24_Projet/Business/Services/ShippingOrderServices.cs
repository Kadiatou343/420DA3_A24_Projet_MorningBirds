using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShippingOrderServices {
    private readonly WsysApplication application;
    private readonly ShippingOrderDAO dao;
    private readonly ShippingOrderView view;

    public ShippingOrderServices(WsysApplication application, WsysDbContext context) {
        this.application = application;
        this.dao = new ShippingOrderDAO(context);

    }

    // Créer un shippingOrder
    public ShippingOrder CreateShippingOrder(ShippingOrder shippingOrder) {
        try {
            return this.dao.Create(shippingOrder);
        } catch (Exception ex) {
            throw new Exception("Impossible de créer le shippingOrder.", ex);
        }
    }

    // Modifier shippingOrder
    public ShippingOrder UpdateShippingOrder(ShippingOrder shippingOrder) {
        try {
            return this.dao.Update(shippingOrder);
        } catch (Exception ex) {
            throw new Exception("Impossible de mettre à jour le shippingOrder.", ex);
        }
    }

    // Supprimer shippingOrder
    public void DeleteShippingOrder(ShippingOrder shippingOrder, bool softDelete = true) {
        try {
            this.dao.Delete(shippingOrder, softDelete);
        } catch (Exception ex) {
            throw new Exception("Impossible de supprimer le shippingOrder.", ex);
        }
    }

    // Obtenir le shippingOrder par son identifiant
    public ShippingOrder? GetShippingOrderById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }
    public ShippingOrder? OpenViewForCreation() {
        ShippingOrder shippingOrder = new ShippingOrder();
        DialogResult result = this.view.OpenForCreation(shippingOrder);
        return result == DialogResult.OK ? shippingOrder : null;
    }

    /// <summary>
    /// Ouvre la vue pour voir un shippingOrder
    /// </summary>
    /// <param name="shippingOrder">le shippingOrder à voir</param>
    /// <returns>le shippingOrder</returns>
    public ShippingOrder OpenViewForView(ShippingOrder shippingOrder) {
        _ = this.view.OpenForView(shippingOrder);
        return shippingOrder;
    }

    /// <summary>
    /// Ouvre la vue pour modifier un shippingOrder
    /// </summary>
    /// <param name="shippingOrder">le shippingOrder à modifier</param>
    /// <returns>la vue ou null</returns>
    public ShippingOrder? OpenViewForModification(ShippingOrder shippingOrder) {
        DialogResult result = this.view.OpenForModification(shippingOrder);
        return result == DialogResult.OK ? shippingOrder : null;
    }

    /// <summary>
    /// ouvre la vue pour supprimer un shippingOrder
    /// </summary>
    /// <param name="shippingOrder">Le shippingOrder a supprimer</param>
    /// <returns>la vue ou null</returns>
    public ShippingOrder? OpenViewForDeletion(ShippingOrder shippingOrder) {
        DialogResult result = this.view.OpenForDeletion(shippingOrder);
        return result == DialogResult.OK ? shippingOrder : null;
    }

}
