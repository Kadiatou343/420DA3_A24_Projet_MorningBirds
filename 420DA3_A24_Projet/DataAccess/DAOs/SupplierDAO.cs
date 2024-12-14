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

    /// <summary>
    /// Constructor of the class
    /// </summary>
    /// <param name="context">The context that need to be passed</param>
    public SupplierDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Create a new supplier 
    /// </summary>
    /// <param name="supplier">The supplier to add</param>
    /// <returns>the supplier added</returns>
    public Supplier Create(Supplier supplier) { 
        _ = this.context.Suppliers.Add(supplier);
        _ = this.context.SaveChanges();

        return supplier;
    }

    /// <summary>
    /// Update an existing supplier 
    /// </summary>
    /// <param name="supplier">the supplier to update</param>
    /// <returns>the updated supplier</returns>
    public Supplier Update(Supplier supplier) { 
        supplier.DateModified = DateTime.Now;
        _ = this.context.Suppliers.Update(supplier);
        _ = this.context.SaveChanges();

        return supplier;
    }

    /// <summary>
    /// Delete an existing Supplier
    /// </summary>
    /// <param name="supplier">the supplier to delete</param>
    /// <param name="softDelete">do we soft delete ?</param>
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

    /// <summary>
    /// Obtenir tout les supplier existants
    /// </summary>
    /// <param name="excludeDeleted">on exlus les supplier deleted ?</param>
    /// <returns>list des supplier</returns>
    public List<Supplier> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Suppliers.ToList()
            : this.context.Suppliers.Where(supplier => supplier.DateDeleted == null).ToList();
    }

    /// <summary>
    /// Obtenir un supplier par son ID
    /// </summary>
    /// <param name="id">le id du supplier</param>
    /// <param name="excludeDeleted">on exlus les supplier deleted ?</param>
    /// <returns>the supplier found</returns>
    public Supplier? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Suppliers
                .Where(supplier => supplier.SupplierId == id)
                .SingleOrDefault()
            : this.context.Suppliers
                .Where(supplier => supplier.SupplierId == id && supplier.DateDeleted == null)
                .SingleOrDefault();
    }

    /// <summary>
    /// Search a supplier by either its name, contact firstname or constact lastname
    /// </summary>
    /// <param name="filter">the search element</param>
    /// <param name="excludeDeleted">on exlus les supplier deleted ?</param>
    /// <returns>a list of supplier based on the filter</returns>
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
