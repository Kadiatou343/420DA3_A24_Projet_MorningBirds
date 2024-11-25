using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class SupplierDAO {
    private readonly WsysDbContext context;

    public SupplierDAO(WsysDbContext context) {
        this.context = context;
    }

    public Supplier Create(Supplier supplier) { 
        _ = this.context.Suppliers.Add(supplier);
        _ = this.context.SaveChanges();

        return supplier;
    }

    public Supplier Update(Supplier supplier) { 
        supplier.DateModified = DateTime.Now;
        _ = this.context.Suppliers.Update(supplier);
        _ = this.context.SaveChanges();

        return supplier;
    }

    public void Delete(Supplier supplier, bool softDelete = true) {
        if (softDelete) {
            supplier.DateDeleted = DateTime.Now;
            _ = this.context.Suppliers.Update(supplier);
            _ = this.context.SaveChanges();
        } else { 
            _ = this.context.Suppliers.Remove(supplier);
            _ = this.context.SaveChanges();
        }
    }

    public List<Supplier> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Suppliers.ToList()
            : this.context.Suppliers.Where(supplier => supplier.DateDeleted == null).ToList();
    }

    public Supplier? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Suppliers
                .Where(supplier => supplier.SupplierId == id)
                .SingleOrDefault()
            : this.context.Suppliers
                .Where(supplier => supplier.SupplierId == id && supplier.DateDeleted == null)
                .SingleOrDefault();
    }

    public List<Supplier> Search(string filter, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Suppliers
                .Where(
                    supplier => (
                         supplier.SupplierName.ToLower().Contains(filter.ToLower())
                         || supplier.ContactFirstName.ToLower().Contains(filter.ToLower())
                         || supplier.ContactLastName.ToLower().Contains(filter.ToLower())))
                .ToList()
            : this.context.Suppliers
                .Where(
                    supplier => (
                         supplier.SupplierName.ToLower().Contains(filter.ToLower())
                         || supplier.ContactFirstName.ToLower().Contains(filter.ToLower())
                         || supplier.ContactLastName.ToLower().Contains(filter.ToLower()))
                         && supplier.DateDeleted == null)
                .ToList();
    }
}
