using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
/// <summary>
/// Classe représentant la classe d'accès aux données d'un role
/// </summary>
internal class RoleDAO {
    /// <summary>
    /// Le context utilisé par le DAO
    /// </summary>
    private readonly WsysDbContext context;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="context">Le contexte de l'applicattion</param>
    public RoleDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Obtenir tous les rôles
    /// </summary>
    /// <param name="excludeDeleted">Detail d'exclure les rôles marqués supprimés ou non</param>
    /// <returns>Liste de rôles</returns>
    public List<Role> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Roles.ToList()
            : this.context.Roles.Where(role => role.DateDeleted == null).ToList();
    }

    /// <summary>
    /// Obtenir un rôle par son identifiant
    /// </summary>
    /// <param name="id">L'identifiant du rôle à rechercher</param>
    /// <param name="excludeDeleted">Detail d'exclure les rôles marqués supprimés ou non</param>
    /// <returns>Le rôle avec cet identifiant</returns>
    public Role? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Roles
                .Where(role => role.Id == id)
                .SingleOrDefault()
            : this.context.Roles
                .Where(role => (role.Id == id && role.DateDeleted == null))
                .SingleOrDefault();
    }

    /// <summary>
    /// Obtenir des roles à partir d'un filtre de recherche
    /// </summary>
    /// <param name="filter">Le filtre de recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les rôles marqués supprimés ou non</param>
    /// <returns>Liste de roles</returns>
    public List<Role> Search(string filter, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Roles
                .Where( 
                    role => (
                         role.RoleName.ToLower().Contains(filter.ToLower())
                         || role.RoleDescription.ToLower().Contains(filter.ToLower())))
                .ToList()
            : this.context.Roles
                .Where(
                    role => (
                         role.RoleName.ToLower().Contains(filter.ToLower())
                         || role.RoleDescription.ToLower().Contains(filter.ToLower()))
                         && role.DateDeleted == null)
                .ToList();
    }

    /// <summary>
    /// Créer un rôle 
    /// </summary>
    /// <param name="role">Le rôle à créer</param>
    /// <returns>Le rôle créé</returns>
    public Role Create(Role role) {
        _ = this.context.Roles.Add(role);
        _ = this.context.SaveChanges();

        return role;
    }

    /// <summary>
    /// Mettre à jour un rôle
    /// </summary>
    /// <param name="role">Le rôle à mettre à jour</param>
    /// <returns>Le rôle mis à jour</returns>
    public Role Update(Role role) {
        role.DateModified = DateTime.Now;
        _ = this.context.Roles.Update(role);
        _ = this.context.SaveChanges();

        return role;
    }

    /// <summary>
    /// Supprimer un rôle
    /// </summary>
    /// <param name="role">Le rôle à supprimer</param>
    /// <param name="softDeleted">Detail de supprimer durement ou de marquer supprimé</param>
    public void Delete(Role role, bool softDeleted = true) {
        if (softDeleted) {
            role.DateDeleted = DateTime.Now;
            _ = this.context.Roles.Update(role);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.Roles.Remove(role);
            _ = this.context.SaveChanges();
        }
    } 
}
