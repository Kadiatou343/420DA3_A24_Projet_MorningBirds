using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class PurchaseOrderDAO {
    private readonly WsysDbContext context;
    public PurchaseOrderDAO(WsysDbContext context) {
        this.context = context;
    }
    public PurchaseOrder Create(PurchaseOrder purchaseOrder) {
        _ = this.context.PurchaseOrders.Add(purchaseOrder);
        _ = this.context.SaveChanges();

        return purchaseOrder;

    }
    public PurchaseOrder? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.PurchaseOrders
               .Where(purchaseOrder => purchaseOrder.Id == id)
               .SingleOrDefault()
            : this.context.PurchaseOrders
               .Where(purchaseOrder => purchaseOrder.Id == id && purchaseOrder.DateDeleted == null)
               .SingleOrDefault();
    }
    public PurchaseOrder Update(PurchaseOrder purchaseOrder) {
        purchaseOrder.DateModified = DateTime.Now;
        _ = this.context.PurchaseOrders.Update(purchaseOrder);
        _ = this.context.SaveChanges();

        return purchaseOrder;
    }
    public List<PurchaseOrder> GetByWarehouse(PurchaseOrder purchaseOrder, bool excludedDeleted = true) {

        return !excludedDeleted
            ? this.context.PurchaseOrders.Include(purchaseOrder => purchaseOrder.Warehouse)
               .Where(
                  purchaseOrder => purchaseOrder.Warehouse != null && purchaseOrder.Warehouse.Equals(purchaseOrder))
               .ToList()
            : this.context.PurchaseOrders.Include(purchaseOrder => purchaseOrder.Warehouse)
            .Where(
                purchaseOrder => purchaseOrder.Warehouse != null && purchaseOrder.Warehouse.Equals(purchaseOrder) && purchaseOrder.DateDeleted == null)
            .ToList();
    }

    public void Delete(PurchaseOrder purchaseOrder, bool softDeleted = true) {
        if (softDeleted) {
            purchaseOrder.DateDeleted = DateTime.Now;
            _ = this.context.PurchaseOrders.Update(purchaseOrder);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.PurchaseOrders.Remove(purchaseOrder);
            _ = this.context.SaveChanges();
        }
    }

    /// <summary>
    /// Obtenir les ordres de restockage ayant le statut
    /// new et dont l'entrépot de destination est le même que l'employé d'entrepôt connecté
    /// </summary>
    /// <param name="user">L'employé d'entrepôt connecté</param>
    /// <returns>La liste de résultats obtenus</returns>
    public List<PurchaseOrder> GetNewPoForWhEmp(User user) {
        return this.context.PurchaseOrders
            .Include(po => po.OrderedProduct)
            .Where(po => (
            po.Status == PurchaseOrderStatusEnum.New
            && po.Warehouse.Equals(user.EmployeeWarehouse)
            ))
            .ToList();
    }

}
