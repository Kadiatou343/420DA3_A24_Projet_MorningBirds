using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class UserDAO {
    private readonly WsysDbContext context;

    public UserDAO(WsysDbContext context) {
        this.context = context;
    }

    public List<User> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Users.Include(user => user.EmployeeWarehouse).ToList()
            : this.context.Users.Include(user => user.EmployeeWarehouse).Where(user => user.DateDeleted == null).ToList();
    }

    public User? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted 
            ? this.context.Users
                .Include(user => user.EmployeeWarehouse)
                .Where(user => user.Id == id)
                .SingleOrDefault()
            : this.context.Users
                .Include (user => user.EmployeeWarehouse)
                .Where(user => (user.Id == id && user.DateDeleted == null))
                .SingleOrDefault();
    }

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

    public User? GetByUsername(string username) {
        return this.context.Users
            .Include(user => user.EmployeeWarehouse)
            .Where(user => (user.Username == username && user.DateDeleted == null))
            .SingleOrDefault();
    }

    public User Create(User user) {
        _ = this.context.Users.Add(user);
        _ = this.context.SaveChanges();

        return user;
    }

    public User Update(User user) {
        user.DateModified = DateTime.Now;
        _ = this.context.Users.Update(user);
        _ = this.context.SaveChanges();

        return user;
    }

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
