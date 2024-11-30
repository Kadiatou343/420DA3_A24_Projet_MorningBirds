using _420DA3_A24_Projet.Business.Domain;
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
/// Classe représentant le service d'un role
/// </summary>
internal class RoleService {
    /// <summary>
    /// Le DAO Rôle
    /// </summary>
    private readonly RoleDAO dao;

    /// <summary>
    /// La fenêtre de vue Rôle
    /// </summary>
    private readonly RoleView window;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application elle-même</param>
    /// <param name="context">Le contexte de l'application</param>
    public RoleService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new RoleDAO(context);
        this.window = new RoleView(parentApp);
    }

    /// <summary>
    /// Obtenir un rôle par son identifiant
    /// </summary>
    /// <param name="id">L'identifiant du rôle à rechercher</param>
    /// <param name="excludeDeleted">Detail d'exclure les rôles marqués supprimés ou non</param>
    /// <returns>Le rôle avec cet identifiant</returns>
    public Role? GetRoleById(int id, bool exludeDeleted = true) {
        return this.dao.GetById(id, exludeDeleted);
    }

    /// <summary>
    /// Obtenir tous les rôles
    /// </summary>
    /// <param name="excludeDeleted">Detail d'exclure les rôles marqués supprimés ou non</param>
    /// <returns>Liste de rôles</returns>
    public List<Role> GetAllRoles(bool excludeDeleted = true) {
        return this.dao.GetAll(excludeDeleted);
    }

    /// <summary>
    /// Créer un rôle 
    /// </summary>
    /// <param name="role">Le rôle à créer</param>
    /// <returns>Le rôle créé</returns>
    public Role CreateRole(Role role) {
        return this.dao.Create(role);
    }

    /// <summary>
    /// Mettre à jour un rôle
    /// </summary>
    /// <param name="role">Le rôle à mettre à jour</param>
    /// <returns>Le rôle mis à jour</returns>
    public Role UpdateRole(Role role) {
        return this.dao.Update(role);
    }

    /// <summary>
    /// Supprimer un rôle
    /// </summary>
    /// <param name="role">Le rôle à supprimer</param>
    /// <param name="softDeleted">Detail de supprimer durement ou de marquer supprimé</param>
    public void DeleteRole(Role role, bool softDeleted = true) {
        this.dao.Delete(role, softDeleted);
    }

    /// <summary>
    /// Obtenir des roles à partir d'un filtre de recherche
    /// </summary>
    /// <param name="filter">Le filtre de recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les rôles marqués supprimés ou non</param>
    /// <returns>Liste de roles</returns>
    public List<Role> SearchRoles(string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }

}
