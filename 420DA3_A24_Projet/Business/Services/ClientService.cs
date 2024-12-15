using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;

    /// <summary>
    /// Service métier pour gérer les opérations liées aux clients. 
    /// Ce service utilise le DAO pour interagir avec la base de données et fournit des méthodes 
    /// pour créer, mettre à jour, supprimer et récupérer des clients.
    /// </summary>
internal class ClientService {

    /// <summary>
    /// L'application parente qui gère l'exécution du système.
    /// </summary>
    
    private readonly WsysApplication parentApp;

    /// <summary>
    /// Le Data Access Object (DAO) pour interagir avec la base de données des clients.
    /// </summary>

    private readonly ClientDAO dao;

    /// <summary>
    /// La vue qui est utilisée pour l'affichage des informations relatives aux clients dans l'interface utilisateur.
    /// </summary>
    
    private readonly ClientView view;


    /// <summary>
    /// Constructeur de la classe ClientService.
    /// Initialise les instances du parentApp, dao et view.
    /// </summary>
    /// <param name="parentApp">L'application parente qui gère l'exécution du système.</param>
    /// <param name="context">Le contexte de base de données pour interagir avec la base de données.</param>
   
    public ClientService(WsysApplication parentApp , WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new ClientDAO(context);
        this.view = new ClientView(parentApp);
    }

    /// <summary>
    /// Crée un nouveau client dans la base de données en utilisant le DAO.
    /// </summary>
    /// <param name="client">L'objet client à créer.</param>
    /// <returns>Le client créé avec son ID généré dans la base de données.</returns>
    /// <exception cref="Exception">Lève une exception si la création du client échoue.</exception>
    
    public Client CreateClient(Client client) {
        try {
            return this.dao.Create(client);
        }catch (Exception ex) {
            throw new Exception("Impossible de créer le client.", ex);
        }
    }

    /// <summary>
    /// Met à jour les informations d'un client existant dans la base de données.
    /// </summary>
    /// <param name="client">L'objet client à mettre à jour.</param>
    /// <returns>Le client mis à jour.</returns>
    /// <exception cref="Exception">Lève une exception si la mise à jour échoue.</exception>
   
    public Client UpdateClient(Client client) {
        try {
            return this.dao.Update(client);
        }catch (Exception ex) {
            throw new Exception("Impossible de mettre à jour le client.", ex);
        }
    }

    /// <summary>
    /// Supprime un client de la base de données.
    /// Par défaut, effectue une suppression logique (soft delete).
    /// </summary>
    /// <param name="client">L'objet client à supprimer.</param>
    /// <param name="softDelete">Indique si la suppression est logique (true) ou physique (false).</param>
    /// <exception cref="Exception">Lève une exception si la suppression échoue.</exception>
   
    public void DeleteClient(Client client, bool softDelete = true) {
        try {
            this.dao.Delete(client, softDelete);
        } catch (Exception ex) {
            throw new Exception("Impossible de supprimer le client.", ex);
        }
    }
    /// <summary>
    /// Récupère un client par son identifiant.
    /// </summary>
    /// <param name="id">L'identifiant du client à récupérer.</param>
    /// <param name="excludeDeleted">Indique si les clients supprimés (logiquement) doivent être exclus de la recherche.</param>
    /// <returns>Le client avec l'identifiant donné, ou null si le client n'existe pas.</returns>
   
    public Client? GetUserById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }


    /// <summary>
    /// Effectue une recherche de clients en fonction d'un filtre.
    /// </summary>
    /// <param name="filter">Le critère de recherche pour filtrer les clients.</param>
    /// <param name="excludeDeleted">Indique si les clients supprimés (logiquement) doivent être exclus de la recherche.</param>
    /// <returns>Une liste de clients correspondant au critère de recherche.</returns>
    
    public List<Client> Search (string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }

}
