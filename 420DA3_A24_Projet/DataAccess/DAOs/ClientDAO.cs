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
internal class ClientDAO {

    //Contexte utilisé par le DAO
    private readonly WsysDbContext context;

    // Le context de l'application
    public ClientDAO(WsysDbContext context) {
        this.context = context;
    }

    public Client Create (Client client) {
        _ = this.context.Clients.Add(client);
        _ = this.context.SaveChanges();

        return client;
    }

    public Client? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Clients
               .Where(client => client.Id == id)
               .SingleOrDefault()
            : this.context.Clients
               .Where(client => client.Id == id && client.DateDeleted == null)
               .SingleOrDefault();
    }


    public Client Update (Client client) {
        client.DateModified = DateTime.Now;
        _ = this.context.Clients.Update(client);
        _ = this.context.SaveChanges();

        return client;
    }

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

    public List <Client> Search (string filter, bool excludeDeleted = true)
    {
        if (!excludeDeleted) {
            return this.context.Clients
               .Where (
                 client => (
                     client.ClientName.ToLower().Contains(filter.ToLower())))
               .ToList();
        } else {
            return this.context.Clients
            .Where (
            client => (
            client.ClientName.ToLower().Contains(filter.ToLower())
            && client.DateDeleted == null))
            .ToList();
        }

    }

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

