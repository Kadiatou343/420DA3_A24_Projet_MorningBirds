using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;
internal class PurchaseOrderServices {
    private readonly WsysApplication application;
    private readonly PurchaseOrderDAO dao;
    private readonly PurchaseOrderView view;

    public PurchaseOrderServices(WsysApplication application, WsysDbContext context) {
        this.application = application;
        this.dao = new PurchaseOrderDAO(context);

    }

    // Créer PurchaseOrder
    public PurchaseOrder CreatePurshageOrder(PurchaseOrder purrhaseOrder) {
        try {
            return this.dao.Create(purrhaseOrder);
        } catch (Exception ex) {
            throw new Exception("Impossible de créer le purchaseOrder.", ex);
        }
    }

    // Modifier PurchaseOrder
    public PurchaseOrder UpdatePurchaseOrder(PurchaseOrder purchaseOrder) {
        try {
            return this.dao.Update(purchaseOrder);
        } catch (Exception ex) {
            throw new Exception("Impossible de mettre à jour le purchaseOrder.", ex);
        }
    }

    // Supprimer PurchaseOrder
    public void DeletepurchaseOrder(PurchaseOrder purchaseOrder, bool softDelete = true) {
        try {
            this.dao.Delete(purchaseOrder, softDelete);
        } catch (Exception ex) {
            throw new Exception("Impossible de supprimer le purchaseOrder.", ex);
        }
    }

    // Obtenir PurchaseOrder par son identifiant
    public PurchaseOrder? GetPurchaseOrderById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }

    public PurchaseOrder? OpenViewForCreation() {
        PurchaseOrder purchaseOrder = new PurchaseOrder();
        DialogResult result = this.view.OpenForCreation(purchaseOrder);
        return result == DialogResult.OK ? purchaseOrder : null;
    }

    /// <summary>
    /// Ouvre la vue pour voir un shippingOrder
    /// </summary>
    /// <param name="shippingOrder">le shippingOrder à voir</param>
    /// <returns>le shippingOrder</returns>
    public PurchaseOrder OpenViewForView(PurchaseOrder purchaseOrder) {
        _ = this.view.OpenForView(purchaseOrder);
        return purchaseOrder;
    }

    /// <summary>
    /// Ouvre la vue pour modifier un shippingOrder
    /// </summary>
    /// <param name="shippingOrder">le shippingOrder à modifier</param>
    /// <returns>la vue ou null</returns>
    public PurchaseOrder? OpenViewForModification(PurchaseOrder purchaseOrder) {
        DialogResult result = this.view.OpenForModification(purchaseOrder);
        return result == DialogResult.OK ? purchaseOrder : null;
    }

    /// <summary>
    /// ouvre la vue pour supprimer un shippingOrder
    /// </summary>
    /// <param name="shippingOrder">Le shippingOrder a supprimer</param>
    /// <returns>la vue ou null</returns>
    public PurchaseOrder? OpenViewForDeletion(PurchaseOrder purchaseOrder) {
        DialogResult result = this.view.OpenForDeletion(purchaseOrder);
        return result == DialogResult.OK ? purchaseOrder : null;
    }

    /// <summary>
    /// Obtenir les ordres de restockage ayant le statut
    /// new pour l'employé d'entrepôt connecté
    /// </summary>
    /// <param name="user">L'employé d'entrepôt connecté</param>
    /// <returns>La liste de résultats obtenus</returns>
    public List<PurchaseOrder> GetNewPoForWhEmp(User user) {
        return this.dao.GetNewPoForWhEmp(user);
    }
}
