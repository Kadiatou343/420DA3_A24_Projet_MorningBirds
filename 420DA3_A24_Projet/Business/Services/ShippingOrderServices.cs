using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShippingOrderServices {
    private readonly WsysApplication application;
    private readonly ShippingOrderDAO dao;

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

}
