using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class PurchaseOrderServices {
    private readonly WsysApplication application;
    private readonly PurchaseOrderDAO dao;

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

    
}
