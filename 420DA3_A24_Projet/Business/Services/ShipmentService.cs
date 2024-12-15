using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;
/// <summary>
/// Classe représentant le service pour le shipment
/// </summary>
internal class ShipmentService {

    private readonly WsysApplication parentApp;
    /// <summary>
    /// Le class DAO Shipment
    /// </summary>
    private readonly ShipmentDAO dao;
    /// <summary>
    /// Le class view pour le Shipment
    /// </summary>
    private readonly ShipmentView view;

    /// <summary>
    /// Constructeur 
    /// </summary>
    /// <param name="parentApp">L'application</param>
    /// <param name="context">Le contexte de l'app</param>
    public ShipmentService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new ShipmentDAO(context);
        this.view = new ShipmentView(parentApp);
    }

    /// <summary>
    /// Créer un shipment
    /// </summary>
    /// <param name="shipment">Shipment à créer</param>
    /// <returns>Le shipment créé</returns>
    public Shipment CreateShipment(Shipment shipment) {
        try {
            return this.dao.Create(shipment);
        } catch (Exception ex) {
            throw new Exception("Impossible de créer le shipment.", ex);
        }
    }

    /// <summary>
    /// Modification shipment
    /// </summary>
    /// <param name="shipment">Shiment à modifier</param>
    /// <returns>Le shipment mis à jour</returns>
    public Shipment UpdateShipment(Shipment shipment) {
        try {
            return this.dao.Update(shipment);
        } catch (Exception ex) {
            throw new Exception("Impossible de mettre à jour le shipment.", ex);
        }
    }

    /// <summary>
    /// Supprimer un shipment
    /// </summary>
    /// <param name="shipment">Shipment à supprimer</param>
    /// <param name="softDelete">Detail de supprimer durement ou de marquer supprimé</param>
    public void DeleteShipment(Shipment shipment, bool softDelete = true) {
        try {
            this.dao.Delete(shipment, softDelete);
        } catch (Exception ex) {
            throw new Exception("Impossible de supprimer le shipment.", ex);
        }
    }

    /// <summary>
    ///  Obtenir un shipment par son Id
    /// </summary>
    /// <param name="id">Id du shipment à chercher</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Le warehouse avec cet id</returns>
    public Shipment GetShipmentById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }

    /// <summary>
    /// Obtenir les shipments par un filtre
    /// </summary>
    /// <param name="filter">Condition de recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste de shipment</returns>
    public List<Shipment> SearchShipment(string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }
    public List<Shipment> GetAllShipment(bool excludeDeleted = true) {
        return this.dao.GetAll(excludeDeleted);
    }

    // TODO: OpenFor ShipmentService
}
