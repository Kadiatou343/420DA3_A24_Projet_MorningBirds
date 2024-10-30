using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class User
    {
        public const int UsernameMaxLength = 64;
        public const int PasswordHashMaxLength = 128;

        // Propriétés des utilisateurs
        
        public int Id {  get; set; }
        public string Username {  get; set; }
        public string PasswordHash { get; set; }
        public int? EmployeeWarehouseId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public List<Role> Roles { get; set; } = new List<Role>();


        // TODO : List<ShippingOrder> CretedShipOrders
        // TODO : List<ShippingOrder> FulfilledShipOrders
        // Proprietes de navigation 
        // TODO: Warehouse? EmployeeWarehouse

        // Construteur de creation 

        public User(string username, string passwordHash, int? employeeWarehouseId)
        {
            this.Username = username;
            this.PasswordHash = passwordHash;
            this.EmployeeWarehouseId = employeeWarehouseId;
        }

        // Constructeurs pour la base de données
        public User(int id,
            string username,
            string passwordHash,
            int? employeeWarehouseId,
            DateTime dateCreated,
            DateTime? dateModified,
            DateTime? dateDeleted,
            byte[] rowVersion) : this(username, passwordHash, employeeWarehouseId)
        {
            this.Id = id;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
        }

        // Methodes de validation

        public bool ValidateUsername(string username)
        {
            return username.Length <= UsernameMaxLength;
        }

        public bool ValidatePasswordHash(string passwordHash)
        {
            return passwordHash.Length <= PasswordHashMaxLength;
        }

        // Methodes pour determiner les roles d'un utilisateurs 
        public bool IsAdministrator()
        {
            foreach (Role role in this.Roles)
            {
                if (role.Id == Role.AdminRoleId)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsOfficeEmployee()
        {
            foreach(Role role in this.Roles)
            {
                if(role.Id == Role.OfficeEmployeeRoleId)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsWarehouseEmployee()
        {
            foreach (Role role in this.Roles)
            {
                if(role.Id == Role.WhEmployeeRoleId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
