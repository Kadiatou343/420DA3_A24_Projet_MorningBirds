using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ShippingOrderDAO {
    private readonly WsysDbContext context;

    public ShippingOrderDAO(WsysDbContext context) {
        this.context = context;
    }
    public ShippingOrder Create(ShippingOrder shippingOrder) {
        _ = this.context.ShippingOrders.Add(shippingOrder);
        _ = this.context.SaveChanges();

        return shippingOrder;

    }
    
    public ShippingOrder? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.ShippingOrders
               .Where(shippingOrder => shippingOrder.Id == id)
               .SingleOrDefault()
            : this.context.ShippingOrders
               .Where(shippingOrder => shippingOrder.Id == id && shippingOrder.DateDeleted == null)
               .SingleOrDefault();
    }
    public ShippingOrder Update(ShippingOrder shippingOrder) {
        shippingOrder.DateModified = DateTime.Now;
        _ = this.context.ShippingOrders.Update(shippingOrder);
        _ = this.context.SaveChanges();

        return shippingOrder;
    }
    public void Delete(ShippingOrder shippingOrder, bool softDeleted = true) {
        if (softDeleted) {
            shippingOrder.DateDeleted = DateTime.Now;
            _ = this.context.ShippingOrders.Update(shippingOrder);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.ShippingOrders.Remove(shippingOrder);
            _ = this.context.SaveChanges();
        }
    }
    public List<ShippingOrder> GetByWarehouse(ShippingOrder shippingOrder, bool excludedDeleted = true) {

        return !excludedDeleted
            ? this.context.ShippingOrders.Include(shippingOrder => shippingOrder.SourceClient)
               .Where(
                  shippingOrder => shippingOrder.SourceClient != null && shippingOrder.SourceClient.Equals(shippingOrder))
               .ToList()
            : this.context.ShippingOrders.Include(shippingOrder => shippingOrder.SourceClient)
            .Where(
                shippingOrder => shippingOrder.SourceClient != null && shippingOrder.SourceClient.Equals(shippingOrder) && shippingOrder.DateDeleted == null)
            .ToList();
    }

    
}
