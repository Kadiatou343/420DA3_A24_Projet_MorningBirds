using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.Business.Domain;
using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _420DA3_A24_Projet.Business;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

    /// <summary>
    /// Data Access Object (DAO) pour la gestion des données des clients dans la base de données.
    /// Cette classe interagit avec la base de données via Entity Framework et fournit des méthodes pour
    /// créer, récupérer, mettre à jour, supprimer et rechercher des clients.
    /// </summary>
internal class ClientDAO {

    /// <summary>
    /// Le contexte de base de données utilisé pour interagir avec la base de données.
    /// </summary>
   
    private readonly WsysDbContext context;

    /// <summary>
    /// Constructeur du DAO pour initialiser le contexte de base de données.
    /// </summary>
    /// <param name="context">Contexte de la base de données utilisé pour interagir avec la base.</param>
 
    public ClientDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Crée un nouveau client dans la base de données.
    /// </summary>
    /// <param name="client">L'objet client à créer.</param>
    /// <returns>Le client créé avec son ID généré dans la base de données.</returns>
    
    public Client Create (Client client) {
        _ = this.context.Clients.Add(client);
        _ = this.context.SaveChanges();

        return client;
    }

    /// <summary>
    /// Récupère un client par son identifiant.
    /// </summary>
    /// <param name="id">L'identifiant du client à récupérer.</param>
    /// <param name="excludeDeleted">Indique si les clients supprimés doivent être exclus de la recherche.</param>
    /// <returns>Le client avec l'identifiant spécifié, ou null si le client n'est pas trouvé.</returns>
   
    public Client? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Clients
               .Where(client => client.Id == id)
               .SingleOrDefault()
            : this.context.Clients
               .Where(client => client.Id == id && client.DateDeleted == null)
               .SingleOrDefault();
    }

    /// <summary>
    /// Met à jour un client dans la base de données.
    /// </summary>
    /// <param name="client">L'objet client à mettre à jour.</param>
    /// <returns>Le client mis à jour.</returns>
    
    public Client Update (Client client) {
        client.DateModified = DateTime.Now;
        _ = this.context.Clients.Update(client);
        _ = this.context.SaveChanges();

        return client;
    }

    /// <summary>
    /// Supprime un client de la base de données. 
    /// Par défaut, la suppression est logique (soft delete).
    /// </summary>
    /// <param name="client">L'objet client à supprimer.</param>
    /// <param name="softDeleted">Indique si la suppression est logique (soft delete) ou physique (hard delete).</param>
    
    public void Delete (Client client, bool softDeleted = true) 
    {
        if (softDeleted) {
            client.DateDeleted = DateTime.Now;
            _ = this.context.Clients.Update(client);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.Clients.Remove(client);
            _ = this.context.SaveChanges();
        }
    }

    /// <summary>
    /// Recherche des clients en fonction d'un filtre sur le nom du client.
    /// </summary>
    /// <param name="filter">Le critère de recherche pour filtrer les clients.</param>
    /// <param name="excludeDeleted">Indique si les clients supprimés doivent être exclus de la recherche.</param>
    
    public List <Client> Search (string filter, bool excludeDeleted = true)
    {
        return !excludeDeleted
            ? this.context.Clients
               .Where (
                 client => (
                     client.ClientName.ToLower().Contains(filter.ToLower())))
               .ToList()
            : this.context.Clients
            .Where (
            client => (
            client.ClientName.ToLower().Contains(filter.ToLower())
            && client.DateDeleted == null))
            .ToList();

    }

    /// <summary>
    /// Récupère les clients associés à un entrepôt spécifique.
    /// </summary>
    /// <param name="warehouse">L'entrepôt auquel les clients sont associés.</param>
    /// <param name="excludedDeleted">Indique si les clients supprimés doivent être exclus de la recherche.</param>
    /// <returns>Une liste de clients associés à l'entrepôt spécifié.</returns>
    
    public List<Client> GetByWH (Warehouse warehouse, bool excludedDeleted = true ) {

        return !excludedDeleted
            ? this.context.Clients.Include(client => client.EmployeeWarehouse)
               .Where (
                  client => client.EmployeeWarehouse != null && client.EmployeeWarehouse.Equals(warehouse))
               .ToList()
            :this.context.Clients.Include(client => client.EmployeeWarehouse)
            .Where(
                client => client.EmployeeWarehouse != null && client.EmployeeWarehouse.Equals(warehouse) && client.DateDeleted == null)
            .ToList();
    }
  
}

