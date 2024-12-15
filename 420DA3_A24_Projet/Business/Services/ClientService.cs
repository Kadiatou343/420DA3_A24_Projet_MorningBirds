using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;
internal class ClientService {

    private readonly WsysApplication application;
    private readonly ClientDAO dao;
    private readonly ClientView view;
    public ClientService(WsysApplication application, WsysDbContext context) {
        this.application = application;
        this.dao = new ClientDAO(context);
        this.view = new ClientView(application);
    }

    // Créer l'utilisateur
    public Client CreateClient(Client client) {
        try {
            return this.dao.Create(client);
        } catch (Exception ex) {
            throw new Exception("Impossible de créer le client.", ex);
        }
    }

    // Modifier l'utilisateur
    public Client UpdateClient(Client client) {
        try {
            return this.dao.Update(client);
        } catch (Exception ex) {
            throw new Exception("Impossible de mettre à jour le client.", ex);
        }
    }

    // Supprimer l'utilisateur
    public void DeleteClient(Client client, bool softDelete = true) {
        try {
            this.dao.Delete(client, softDelete);
        } catch (Exception ex) {
            throw new Exception("Impossible de supprimer le client.", ex);
        }
    }

    // Obtenir le client par son identifiant
    public Client? GetUserById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }


    //Obtenir les clients par recherche
    public List<Client> Search(string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }

}
