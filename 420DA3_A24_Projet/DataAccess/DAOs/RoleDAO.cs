using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class RoleDAO {
    private readonly WsysDbContext context;

    public RoleDAO(WsysDbContext context) {
        this.context = context;
    }

    public List<Role> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Roles.ToList()
            : this.context.Roles.Where(role => role.DateDeleted == null).ToList();
    }

    public Role? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Roles
                .Where(role => role.Id == id)
                .SingleOrDefault()
            : this.context.Roles
                .Where(role => (role.Id == id && role.DateDeleted == null))
                .SingleOrDefault();
    }

    public List<Role> SearchRoles(string filter, bool excludeDeleted = true) {
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

    public Role Create(Role role) {
        _ = this.context.Roles.Add(role);
        _ = this.context.SaveChanges();

        return role;
    }

    public Role Update(Role role) {
        role.DateModified = DateTime.Now;
        _ = this.context.Roles.Update(role);
        _ = this.context.SaveChanges();

        return role;
    }

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
