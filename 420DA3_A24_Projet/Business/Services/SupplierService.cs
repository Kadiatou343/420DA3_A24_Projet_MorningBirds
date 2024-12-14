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
/// <summary>
/// Class représentant le service d'un supplier
/// </summary>
internal class SupplierService {
    /// <summary>
    /// Le dao du supplier
    /// </summary>
    private SupplierDAO dao;
    /// <summary>
    /// La view associer a ce service de supplier 
    /// </summary>
    private SupplierView view;

    /// <summary>
    /// Constructeur de la class
    /// </summary>
    /// <param name="parentApp">the parent app to pass it to the view</param>
    /// <param name="context">The context that the DAO need</param>
    public SupplierService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new SupplierDAO(context);
        this.view = new SupplierView(parentApp);
    }

    /// <summary>
    /// From a search element return a list of supplier
    /// </summary>
    /// <param name="searchElement">the search element</param>
    /// <param name="excludeDeleted">exclude deleted supplier ?</param>
    /// <returns>A list of supplier</returns>
    public List<Supplier> SearchSupplier(string searchElement, bool excludeDeleted = true) { 
        return this.dao.Search(searchElement, excludeDeleted);
    }

    /// <summary>
    /// Create new supplier 
    /// </summary>
    /// <param name="supplier">The new supplier to create</param>
    /// <returns>the new supplier created </returns>
    public Supplier CreateSupplier(Supplier supplier) { 
        return this.dao.Create(supplier);   
    }

    /// <summary>
    /// Update an existing supplier
    /// </summary>
    /// <param name="supplier">The supplier to update</param>
    /// <returns>the updated supplier </returns>
    public Supplier UpdateSupplier(Supplier supplier) { 
        return this.dao.Update(supplier);
    }

    /// <summary>
    /// Delete a existing supplier 
    /// </summary>
    /// <param name="supplier">The supplier to delete</param>
    /// <param name="softDelete">DO we soft delete of no ?</param>
    public void DeleteSupplier(Supplier supplier, bool softDelete = true) { 
        this.dao.Delete(supplier, softDelete);
    }

    /// <summary>
    /// Ge all the existing supplier and return a list of supplier 
    /// </summary>
    /// <param name="excludeDeleted">do we pass deleted supplier ?</param>
    /// <returns>a list of supplier</returns>
    public List<Supplier> GetAllSupplier(bool excludeDeleted = true) { 
        return this.dao.GetAll(excludeDeleted);
    }

    /// <summary>
    /// Get a specific supplier based on is ID
    /// </summary>
    /// <param name="id">the id of the supplier</param>
    /// <param name="excludeDeleted">Exclude deleted supplier ?</param>
    /// <returns>the supplier found</returns>
    public Supplier? GetSupplierById(int id, bool excludeDeleted = true) { 
        return this.dao.GetById(id, excludeDeleted);    
    }
}
