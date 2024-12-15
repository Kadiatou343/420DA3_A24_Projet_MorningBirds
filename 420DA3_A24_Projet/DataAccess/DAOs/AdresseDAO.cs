using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
    /// <summary>
    /// Classe qui gère l'accès aux données des adresses dans la base de données.
    /// Fournit des méthodes pour effectuer des opérations CRUD (création, récupération, mise à jour, suppression) sur les adresses.
    /// </summary>
internal class AdresseDAO {

    private readonly WsysDbContext context; // Contexte de la base de données

    /// <summary>
    /// Constructeur de la classe AdresseDAO. 
    /// Initialise le contexte de la base de données pour les opérations d'accès aux données.
    /// </summary>
    /// <param name="context">Contexte de la base de données utilisé pour interagir avec les tables des adresses.</param>
    public AdresseDAO(WsysDbContext context) {
            this.context = context;
    }

    /// <summary>
    /// Crée une nouvelle adresse dans la base de données.
    /// </summary>
    /// <param name="address">L'adresse à ajouter à la base de données.</param>
    /// <returns>L'adresse nouvellement créée.</returns>
    
    public Address Create(Address address) {
        _ = this.context.Addresses.Add(address);
        _ = this.context.SaveChanges();

        return address;

    }

    /// <summary>
    /// Récupère une adresse par son identifiant, avec la possibilité d'exclure les adresses supprimées.
    /// </summary>
    /// <param name="id">L'identifiant de l'adresse à récupérer.</param>
    /// <param name="excludeDeleted">Indique si les adresses supprimées doivent être exclues de la recherche.</param>
    /// <returns>L'adresse correspondante ou null si non trouvée.</returns>
    
    public Address? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Addresses
                .Where(address => address.Id == id)
                .SingleOrDefault()
            : this.context.Addresses
                .Where(address => address.Id == id && address.DateDeleted == null)
                .SingleOrDefault();
    }

    /// <summary>
    /// Met à jour une adresse existante dans la base de données.
    /// </summary>
    /// <param name="address">L'adresse mise à jour à enregistrer dans la base de données.</param>
    /// <returns>L'adresse mise à jour.</returns>
    
    public Address Update( Address address) {
        address.DateModified = DateTime.Now;
        _ = this.context.Addresses.Update(address);
        _ = this.context.SaveChanges();

        return address;
    }

    /// <summary>
    /// Recherche des adresses en fonction d'un critère de filtre et de l'option d'exclusion des adresses supprimées.
    /// </summary>
    /// <param name="filter">Critère de recherche pour filtrer les adresses par leur champ Addresse.</param>
    /// <param name="excludeDeleted">Indique si les adresses supprimées doivent être exclues de la recherche.</param>
    /// <returns>Une liste d'adresses correspondant au critère de recherche.</returns>

    public List<Address> Search(string filter, bool excludeDeleted = true) {
    return !excludeDeleted
        ? this.context.Addresses
                .Where(
                    address => (
                        address.Addresse.ToLower().Contains(filter.ToLower())))
                .ToList()
        : this.context.Addresses
            .Where(
            address=> (
            address.Addresse.ToLower().Contains(filter.ToLower())
            && address.DateDeleted == null))
            .ToList();

    }

    /// <summary>
    /// Récupère une liste d'adresses associées à un entrepôt spécifique, avec la possibilité d'exclure les adresses supprimées.
    /// </summary>
    /// <param name="warehouse">L'entrepôt pour lequel on cherche les adresses associées.</param>
    /// <param name="excludedDeleted">Indique si les adresses supprimées doivent être exclues de la recherche.</param>
    /// <returns>Une liste d'adresses associées à l'entrepôt spécifié.</returns>
    
    public List<Address> GetByWarehouse (Warehouse warehouse, bool excludedDeleted = true) {

        return !excludedDeleted
            ? this.context.Addresses.Include(address => address.OwnerWarehouse)
                .Where(
                    address => address.OwnerWarehouse != null && address.OwnerWarehouse.Equals(warehouse))
                .ToList()
            : this.context.Addresses.Include(address => address.OwnerWarehouse)
            .Where(
                address => address.OwnerWarehouse != null && address.OwnerWarehouse.Equals(warehouse) && address.DateDeleted == null)
            .ToList();
    }

    /// <summary>
    /// Récupère une liste d'adresses associées à un ordre d'expédition spécifique, avec la possibilité d'exclure les adresses supprimées.
    /// </summary>
    /// <param name="shippingOrder">L'ordre d'expédition pour lequel on cherche les adresses associées.</param>
    /// <param name="excludedDeleted">Indique si les adresses supprimées doivent être exclues de la recherche.</param>
    /// <returns>Une liste d'adresses associées à l'ordre d'expédition spécifié.</returns>
    
    public List<Address> GetByShippingOrder(ShippingOrder shippingOrder, bool excludedDeleted = true) {

        return !excludedDeleted
            ? this.context.Addresses.Include(address => address.OwnerShipOrder)
                .Where(
                    address => address.OwnerShipOrder != null && address.OwnerShipOrder.Equals(shippingOrder))
                .ToList()
            : this.context.Addresses.Include(address => address.OwnerShipOrder)
            .Where(
                address=> address.OwnerShipOrder!= null && address.OwnerShipOrder.Equals(shippingOrder) && address.DateDeleted == null)
            .ToList();
    }
    public List<Address> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Addresses.ToList()
            : this.context.Addresses.Where(adress => adress.DateDeleted == null).ToList();
    }

}
