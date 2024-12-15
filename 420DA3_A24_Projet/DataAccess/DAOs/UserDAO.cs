using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
/// <summary>
/// Classe représentant la classe d'accès aux données d'un utilisateur
/// </summary>
internal class UserDAO {
    /// <summary>
    /// Le contexte utilisé par le DAO
    /// </summary>
    private readonly WsysDbContext context;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="context">Le contexte de l'application</param>
    public UserDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Obtenir tous les utilisateurs
    /// </summary>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste d'utilisateurs</returns>
    public List<User> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Users.Include(user => user.EmployeeWarehouse).ToList()
            : this.context.Users.Include(user => user.EmployeeWarehouse).Where(user => user.DateDeleted == null).ToList();
    }

    /// <summary>
    /// Obtebir un utilisateur par son identifiant 
    /// </summary>
    /// <param name="id">L'identifiant de l'utilisateur à rechercher</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>L'utilisateur avec cet identifiant</returns>
    public User? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Users
                .Include(user => user.EmployeeWarehouse)
                .Where(user => user.Id == id)
                .SingleOrDefault()
            : this.context.Users
                .Include(user => user.EmployeeWarehouse)
                .Where(user => user.Id == id && user.DateDeleted == null)
                .SingleOrDefault();
    }

    /// <summary>
    /// Obtenir les utilisateurs par un filtre de recherche
    /// </summary>
    /// <param name="filter">Le filtre de recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste d'utilisateurs</returns>
    public List<User> Search(string filter, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Users.Include(user => user.EmployeeWarehouse)
                .Where(
                    user => user.Username.ToLower().Contains(filter.ToLower()))
                .ToList()
            : this.context.Users.Include(user => user.EmployeeWarehouse)
                .Where(
                    user => user.Username.ToLower().Contains(filter.ToLower())
                        && user.DateDeleted == null)
                .ToList();
    }

    /// <summary>
    /// Obtebir les utilisateurs en fonction d'un entrepôt 
    /// </summary>
    /// <param name="warehouse">L'entrepôt pour faire la recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste d'utilisateurs</returns>
    public List<User> GetByWarehouse(Warehouse warehouse, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Users.Include(user => user.EmployeeWarehouse)
                .Where(
                    user => user.EmployeeWarehouse != null && user.EmployeeWarehouse.Equals(warehouse))
                .ToList()
            : this.context.Users.Include(user => user.EmployeeWarehouse)
                .Where(
                    user => user.EmployeeWarehouse != null && user.EmployeeWarehouse.Equals(warehouse)
                        && user.DateDeleted == null)
                .ToList();
    }

    /// <summary>
    /// Obtenir un utilisateur par son nom d'utilisateur
    /// </summary>
    /// <param name="username">Le nom d'utilisateur de l'utilisateur à rechercher</param>
    /// <returns>L'utilisateur avec ce username</returns>
    public User? GetByUsername(string username) {
        return this.context.Users
            .Include(user => user.EmployeeWarehouse)
            .Where(user => user.Username == username && user.DateDeleted == null)
            .SingleOrDefault();
    }

    /// <summary>
    /// Créer un utilisateur
    /// </summary>
    /// <param name="user">L'utilisateur à créer</param>
    /// <returns>L'utilisateur créé</returns>
    public User Create(User user) {
        _ = this.context.Users.Add(user);
        _ = this.context.SaveChanges();

        return user;
    }

    /// <summary>
    /// Mettre à jour un utilisateur
    /// </summary>
    /// <param name="user">L'utilisateur à mettre à jour</param>
    /// <returns>L'utilisateur mis à jour</returns>
    public User Update(User user) {
        user.DateModified = DateTime.Now;
        _ = this.context.Users.Update(user);
        _ = this.context.SaveChanges();

        return user;
    }

    /// <summary>
    /// Supprimer un utilisateur
    /// </summary>
    /// <param name="user">L'utilisateur à supprimer</param>
    /// <param name="softDelete">Detail de supprimer durement ou de marquer supprimé</param>
    public void Delete(User user, bool softDelete = true) {
        if (softDelete) {
            user.DateDeleted = DateTime.Now;
            _ = this.context.Users.Update(user);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.Users.Remove(user);
            _ = this.context.SaveChanges();
        }
    }

}
