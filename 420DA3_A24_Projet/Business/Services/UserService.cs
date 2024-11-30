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
internal class UserService {
    private readonly UserDAO dao;
    private readonly UserView window;

    public UserService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new UserDAO(context);
        this.window = new UserView(parentApp);
    }

    public User CreateUser(User user) {
        return this.dao.Create(user);
    }

    public User UpdateUser(User user) {
        return this.dao.Update(user);
    }

    public User? GetUserById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }

    public User? GetByUsername(string username) {
        return this.dao.GetByUsername(username);
    }

    public List<User> GetAllUsers(bool excludeDeleted = true) {
        return this.dao.GetAll(excludeDeleted);
    }

    public List<User> GetUsersByWarehouse(Warehouse warehouse, bool excludeDeleted = true) {
        return this.dao.GetByWarehouse(warehouse, excludeDeleted);
    }

    public List<User> SearchUsers(string filter, bool excludeDeleted = true) {
        return this.dao.Search(filter, excludeDeleted);
    }

    public void DeleteUser(User user, bool softDelete = true) {
        this.dao.Delete(user, softDelete);
    }




}
