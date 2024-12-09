using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
