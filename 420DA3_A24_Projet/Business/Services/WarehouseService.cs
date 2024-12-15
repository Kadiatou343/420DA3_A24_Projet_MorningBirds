using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;
internal class WarehouseService {

    private readonly WsysApplication parentApp;
    /// <summary>
    /// Le class DAO Warehouse
    /// </summary>
    private readonly WarehouseDAO dao;
    /// <summary>
    /// Le class view pour le Warehouse
    /// </summary>
    private readonly WarehouseView view;

    /// <summary>
    /// Constructeur 
    /// </summary>
    /// <param name="parentApp">L'application</param>
    /// <param name="context">Le contexte de l'app</param>
    public WarehouseService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new WarehouseDAO(context);
        this.view = new WarehouseView(parentApp);
    }

    /// <summary>
    /// Créer un warehouse
    /// </summary>
    /// <param name="warehouse">Warehouse à créer</param>
    /// <returns>Le warehouse créé</returns>
    public Warehouse CreateWarehouse(Warehouse warehouse) {
        try {
            return this.dao.Create(warehouse);
        } catch(Exception ex){
            throw new Exception("Impossible de créer le warehouse.", ex);
        }
    }

    /// <summary>
    /// Modification warehouse
    /// </summary>
    /// <param name="warehouse">Warehouse à modifier</param>
    /// <returns>Le warehouse mis à jour</returns>
    public Warehouse UpdateWarehouse(Warehouse warehouse) {
        try {
            return this.dao.Update(warehouse);
        } catch(Exception ex) {
            throw new Exception("Impossible de mettre à jour le shipment.", ex);
        }
    }

    /// <summary>
    /// Supprimer un warehouse
    /// </summary>
    /// <param name="warehouse">Warehouse à supprimer</param>
    /// <param name="softDelete">Detail de supprimer durement ou de marquer supprimé</param>
    public void DeleteWarehouse(Warehouse warehouse, bool softDelete = true) {
        try {
            this.dao.Delete(warehouse, softDelete);
        } catch(Exception ex) {
            throw new Exception("Impossible de supprimer le warehouse.", ex);
        }
    }

    /// <summary>
    ///  Obtenir un warehouse par son Id
    /// </summary>
    /// <param name="id">Id du warehouse à chercher</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Le warehouse avec cet id</returns>
    public Warehouse GetWarehouseById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }

    /// <summary>
    /// Obtenir les warehouse par un filtre 
    /// </summary>
    /// <param name="filter">Condition de recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste de warehouse</returns>
    public List<Warehouse> SearchWarehouse(string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }

    /// <summary>
    /// Obtenir touts les warehouse
    /// </summary>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>La liste de touts les warehouse</returns>
    public List<Warehouse> GetAllWarehouse(bool excludeDeleted = true) {
        return this.dao.GetAll(excludeDeleted);
    }

    // TODO: OpenFor WarehouseService
}
