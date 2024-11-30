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
internal class RoleService {

    private readonly RoleDAO dao;
    private readonly RoleView window;

    public RoleService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new RoleDAO(context);
        this.window = new RoleView(parentApp);
    }

    public Role? GetRoleById(int id, bool exludeDeleted = true) {
        return this.dao.GetById(id, exludeDeleted);
    }

    public List<Role> GetAllRoles(bool excludeDeleted = true) {
        return this.dao.GetAll(excludeDeleted);
    }

    public Role CreateRole(Role role) {
        return this.dao.Create(role);
    }

    public Role UpdateRole(Role role) {
        return this.dao.Update(role);
    }

    public void DeleteRole(Role role, bool softDeleted = true) {
        this.dao.Delete(role, softDeleted);
    }

    public List<Role> SearchRoles(string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }

}
