using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
/// <summary>
/// Classe représentant la classe d'accès aux données d'un Warehouse
/// </summary>
internal class WarehouseDAO {
    /// <summary>
    /// Le contexte utilisé par le DAO
    /// </summary>
    private readonly WsysDbContext context;
    
    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="context">Contexte de l'app</param>
    public WarehouseDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Créer un Warehouse
    /// </summary>
    /// <param name="warehouse">Le objet type Warehouse à créer</param>
    /// <returns>Le warehouse créé</returns>
    public Warehouse Create(Warehouse warehouse) {
        _ = this.context.Warehouses.Add(warehouse);
        _ = this.context.SaveChanges();

        return warehouse;
    }

    /// <summary>
    /// Modification d'un warehouse
    /// </summary>
    /// <param name="warehouse">WArehouse à modifier</param>
    /// <returns>Le warehouse mis à jour</returns>
    public Warehouse Update(Warehouse warehouse) {
        warehouse.DateModified = DateTime.Now;
        _ = this.context.Warehouses.Update(warehouse);
        _ = this.context.SaveChanges();

        return warehouse;
    }

    /// <summary>
    /// Supprimmer un warehouse
    /// </summary>
    /// <param name="warehouse">Warehouse à supprimer</param>
    /// <param name="softDelete">Detail de supprimer durement ou de marquer supprimé</param>
    public void Delete(Warehouse warehouse, bool softDelete = true) {
        if (softDelete) {
            warehouse.DateDeleted = DateTime.Now;
            _ = this.context.Warehouses.Update(warehouse);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.Warehouses.Remove(warehouse);
            _ = this.context.SaveChanges();
        }
    }

    /// <summary>
    /// Obtenir un warehouse par son Id
    /// </summary>
    /// <param name="id">Id du warehouse à chercher</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Le warehouse avec cet id</returns>
    public Warehouse? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Warehouses
                .Where(warehouse => warehouse.Id == id)
                .SingleOrDefault()
            : this.context.Warehouses
                .Where(warehouse => warehouse.Id == id && warehouse.DateDeleted == null)
                .SingleOrDefault();
    }

    /// <summary>
    /// Obtenir les warehouse par un filtre 
    /// </summary>
    /// <param name="filter">Condition de recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste de warehouse</returns>
    public List<Warehouse> Search(string filter, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Warehouses
                .Where(
                    warehouse => 
                        warehouse.WareHouseName.ToLower().Contains(filter.ToLower()))
                .ToList()
            : this.context.Warehouses
                .Where(
                    warehouse => 
                        warehouse.WareHouseName.ToLower().Contains(filter.ToLower())
                        && warehouse.DateDeleted == null)
                .ToList();
    }

    /// <summary>
    /// Obtenir touts les warehouse
    /// </summary>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>La liste de touts les warehouse</returns>
    public List<Warehouse> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Warehouses.ToList()
            : this.context.Warehouses
                .Where(warehouse => warehouse.DateDeleted == null)
                .ToList();
    }

}
