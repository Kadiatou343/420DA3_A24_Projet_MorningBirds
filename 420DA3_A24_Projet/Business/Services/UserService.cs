﻿using _420DA3_A24_Projet.Business.Domain;
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
/// Classe représentant le service d'un utilisateur
/// </summary>
internal class UserService {

    /// <summary>
    /// Le DAO Utilisateur
    /// </summary>
    private readonly UserDAO dao;

    /// <summary>
    /// La fenetre de vue Utilisateur
    /// </summary>
    private readonly UserView window;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application elle-même</param>
    /// <param name="context">Le contexte de l'application</param>
    public UserService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new UserDAO(context);
        this.window = new UserView(parentApp);
    }

    /// <summary>
    /// Créer un utilisateur
    /// </summary>
    /// <param name="user">L'utilisateur à créer</param>
    /// <returns>L'utilisateur créé</returns>
    public User CreateUser(User user) {
        return this.dao.Create(user);
    }

    /// <summary>
    /// Mettre à jour un utilisateur
    /// </summary>
    /// <param name="user">L'utilisateur à mettre à jour</param>
    /// <returns>L'utilisateur mis à jour</returns>
    public User UpdateUser(User user) {
        return this.dao.Update(user);
    }

    /// <summary>
    /// Obtebir un utilisateur par son identifiant 
    /// </summary>
    /// <param name="id">L'identifiant de l'utilisateur à rechercher</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>L'utilisateur avec cet identifiant</returns>
    public User? GetUserById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }

    /// <summary>
    /// Obtenir un utilisateur par son nom d'utilisateur
    /// </summary>
    /// <param name="username">Le nom d'utilisateur de l'utilisateur à rechercher</param>
    /// <returns>L'utilisateur avec ce username</returns>
    public User? GetByUsername(string username) {
        return this.dao.GetByUsername(username);
    }

    /// <summary>
    /// Obtenir tous les utilisateurs
    /// </summary>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste d'utilisateurs</returns>
    public List<User> GetAllUsers(bool excludeDeleted = true) {
        return this.dao.GetAll(excludeDeleted);
    }

    /// <summary>
    /// Obtebir les utilisateurs en fonction d'un entrepôt 
    /// </summary>
    /// <param name="warehouse">L'entrepôt pour faire la recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste d'utilisateurs</returns>
    public List<User> GetUsersByWarehouse(Warehouse warehouse, bool excludeDeleted = true) {
        return this.dao.GetByWarehouse(warehouse, excludeDeleted);
    }

    /// <summary>
    /// Obtenir les utilisateurs par un filtre de recherche
    /// </summary>
    /// <param name="filter">Le filtre de recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste d'utilisateurs</returns>
    public List<User> SearchUsers(string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }

    /// <summary>
    /// Supprimer un utilisateur
    /// </summary>
    /// <param name="user">L'utilisateur à supprimer</param>
    /// <param name="softDelete">Detail de supprimer durement ou de marquer supprimé</param>
    public void DeleteUser(User user, bool softDelete = true) {
        this.dao.Delete(user, softDelete);
    }




}
