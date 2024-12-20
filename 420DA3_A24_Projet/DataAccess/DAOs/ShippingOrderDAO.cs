﻿using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Project_Utilities.Enums;

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

    public List<ShippingOrder> GetUnassignedSoForWhEmp(User user) {
        return this.context.ShippingOrders
            .Include(so => so.SourceClient)
            .Where(so => (
            so.Status == ShippingOrderStatusEnum.Unassigned
            && so.SourceClient.AssignedWarehouse.Equals(user.EmployeeWarehouse)
            ))
            .ToList();

    }

    public List<ShippingOrder> GetFulfilledSoForWhEmp(User user) {
        return this.context.ShippingOrders
            .Include(so => so.FulfillerEmployee)
            .Where(so => (
            so.Status == ShippingOrderStatusEnum.Processing
            && user.Equals(so.FulfillerEmployee)
            ))
            .ToList();

    }

    public List<ShippingOrder> GetPackagedSoForWhEmp(User user) {
        return this.context.ShippingOrders
            .Include(so => so.SourceClient)
            .Where(so => (
            so.Status == ShippingOrderStatusEnum.Packaged
            && so.SourceClient.AssignedWarehouse.Equals(user.EmployeeWarehouse)
            ))
            .ToList();

    }

    public List<ShippingOrder> Search(string filter, bool excludeDeleted = true) {
        return this.context.ShippingOrders
                .Include(so => so.SourceClient)
                .Where(
                    shippingOrder =>
                         (shippingOrder.Id.ToString().ToLower().Contains(filter.ToLower())
                         || shippingOrder.SourceClient.ClientName.ToLower().Contains(filter.ToLower()))
                         && (excludeDeleted || shippingOrder.DateDeleted == null)
                )
                .ToList();
    }

}
