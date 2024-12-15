using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Service de gestion des adresses, responsable des opérations CRUD (création, mise à jour, recherche)
/// pour les adresses, ainsi que des recherches spécifiques basées sur l'entrepôt ou l'ordre d'expédition.
/// </summary
internal class AdresseService {

    // Déclaration des dépendances utilisées par le service.

    private readonly WsysApplication parentApp; // Application principale
    private readonly AdresseDAO dao; // Data Access Object (DAO) pour interagir avec la base de données
    private readonly AddressView view; // Vue utilisée pour l'affichage dans l'interface utilisateur

    /// <summary>
    /// Constructeur du service AdresseService.
    /// </summary>
    /// <param name="parentApp">L'application principale (WsysApplication) qui utilise ce service.</param>
    /// <param name="context">Contexte de la base de données (WsysDbContext) utilisé pour accéder aux données.</param>
    public AdresseService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new AdresseDAO(context);
        this.view = new AddressView(parentApp);
    }

    /// <summary>
    /// Crée une nouvelle adresse dans la base de données.
    /// </summary>
    /// <param name="address">L'objet Address à créer dans la base de données.</param>
    /// <returns>L'adresse créée.</returns>
    /// <exception cref="Exception">Lance une exception si la création échoue.</exception>

    public Address CreateAddress(Address address) {
        try {
            return this.dao.Create(address);
        } catch (Exception ex) {
            throw new Exception("Impossible de créer l'adresse", ex);
        }

    }

    /// <summary>
    /// Met à jour les informations d'une adresse existante dans la base de données.
    /// </summary>
    /// <param name="address">L'objet Address avec les nouvelles informations à mettre à jour.</param>
    /// <returns>L'adresse mise à jour.</returns>
    /// <exception cref="Exception">Lance une exception si la mise à jour échoue.</exception>

    public Address UpdateAdresse(Address address) {
        try {
            return this.dao.Update(address);
        } catch (Exception ex) {
            throw new Exception("Impossible de mettre à jour l'addresse", ex);
        }
    }

    /// <summary>
    /// Recherche des adresses en fonction d'un filtre et de l'option d'exclusion des adresses supprimées.
    /// </summary>
    /// <param name="filter">Critère de recherche pour filtrer les adresses.</param>
    /// <param name="excludeDeleted">Indique si les adresses supprimées doivent être exclues de la recherche.</param>
    /// <returns>Une liste d'adresses correspondant aux critères de recherche.</returns>

    public List<Address> Search(string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }


    /// <summary>
    /// Récupère une liste d'adresses associées à un entrepôt spécifique.
    /// </summary>
    /// <param name="warehouse">L'entrepôt pour lequel on récupère les adresses.</param>
    /// <param name="excludedDeleted">Indique si les adresses supprimées doivent être exclues.</param>
    /// <returns>Une liste d'adresses associées à l'entrepôt spécifié.</returns>

    public List<Address> GetAddresseByWarehouse(Warehouse warehouse, bool excludedDeleted = true) {
        return this.dao.GetByWarehouse(warehouse, excludedDeleted);
    }

    /// <summary>
    /// Récupère une liste d'adresses associées à un ordre d'expédition spécifique.
    /// </summary>
    /// <param name="shippingorder">L'ordre d'expédition pour lequel on récupère les adresses.</param>
    /// <param name="excludedDeleted">Indique si les adresses supprimées doivent être exclues.</param>
    /// <returns>Une liste d'adresses associées à l'ordre d'expédition spécifié.</returns>

    public List<Address> GetAddressByShippingorder(ShippingOrder shippingorder, bool excludedDeleted = true) {
        return this.dao.GetByShippingOrder(shippingorder, excludedDeleted);
    }
    public List<Address> GetAllAddress(bool excludeDeleted = true) {
        return this.dao.GetAll(excludeDeleted);
    }
}
