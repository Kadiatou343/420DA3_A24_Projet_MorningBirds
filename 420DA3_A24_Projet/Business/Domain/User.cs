using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    /// <summary>
    /// Classe représentant un utilisateur 
    /// </summary>
    public class User
    {
        /// <summary>
        /// Longueur maximale du nom d'utilisateur
        /// </summary>
        public const int USERNAME_MAX_LENGTH = 64;

        /// <summary>
        /// Longueur minimale du nom d'utilisateur
        /// </summary>
        public const int USERNAME_MIN_LENGTH = 4;

        /// <summary>
        /// Longueur maximale du hash du mot de passe de l'utilisateur 
        /// </summary>
        public const int PASSWORDHASH_MAX_LENGTH = 128;

        /// <summary>
        /// Longueur minimale du mot de passe de l'utilisateur
        /// </summary>
        public const int PASSWORD_MIN_LENGTH = 8;

        /// <summary>
        /// Longueur maximale du mot de passe de l'utilisateur
        /// </summary>
        public const int PASSWORD_MAX_LENGTH = 32;

        private string username = null!;
        private string passwordHash = null!;


        // Identifiants
        public int Id {  get; set; }

        // Données de l'utilisateur 
        public string Username {
            get { return this.username; }
            set {
                if (!this.ValidateUsername(value)) {
                    throw new ArgumentOutOfRangeException("Username", $"La longueur de Username devrait être inférieur à {USERNAME_MAX_LENGTH} ou supérieure à {USERNAME_MIN_LENGTH} !");
                }
                this.username = value;
            }
        }
        public string PasswordHash {
            get { return this.passwordHash; }
            set {
                if (!this.ValidatePasswordHash(value)) {
                    throw new ArgumentOutOfRangeException("PasswordHash", $"La longueur de PasswordHash devrait être inférieur à {PASSWORDHASH_MAX_LENGTH} !");
                }
                this.passwordHash = value;
            }
        }
        public int? EmployeeWarehouseId { get; set; }

        // Meta-donnees 
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; } = null!;

        // Proprietes de navigation EF Core

        /// <summary>
        /// L'entrepot associé à cet utilisateur s'il est un employé d'entrepot
        /// </summary>
        public virtual Warehouse EmployeeWarehouse { get; set; } = null!;

        /// <summary>
        /// Les rôles associés à cet utilisateur 
        /// </summary>
        public virtual List<Role> Roles { get; set; } = new List<Role>();

        /// <summary>
        /// Les commandes d'expedition crées pas cet utilisateur s'il est employé de bureau ou admin
        /// </summary>
        public virtual List<ShippingOrder> CreatedShipOrders { get; set; } = new List<ShippingOrder>();

        /// <summary>
        /// Les commandes d'expedition executés par cet utilisateur s'il est employé de bureau ou admin
        /// </summary>
        public virtual List<ShippingOrder> FulfilledShipOrders { get; set; } = new List<ShippingOrder>();


        /// <summary>
        /// Constructeur orienté création manuelle 
        /// </summary>
        /// <param name="username">Le nom d'utilisateur de l'utilisateur</param>
        /// <param name="passwordHash">Le Hash du mot de passe de l'utilisateur</param>
        /// <param name="employeeWarehouseId">L'identifiant de l'entrepot associé à l'utilisateur s'il est un employé d'entrepot</param>

        public User(string username, string passwordHash, int? employeeWarehouseId = null)
        {
            this.Username = username;
            this.PasswordHash = passwordHash;
            this.EmployeeWarehouseId = employeeWarehouseId;
        }

        /// <summary>
        /// Constructeur orienté création par Entity Framework
        /// </summary>
        /// <param name="id">L'identifiant de l'utilisateur</param>
        /// <param name="username">Le nom d'utilisateur de l'utilisateur</param>
        /// <param name="passwordHash">Le Hash du mot de passe de l'utilisateur</param>
        /// <param name="employeeWarehouseId">L'identifiant de l'entrepot associé à l'utilisateur s'il est un employé d'entrepot</param>
        /// <param name="dateCreated">La date de création de l'utilisateur</param>
        /// <param name="dateModified">La date de modification de l'utilisateur</param>
        /// <param name="dateDeleted">La date de suppression de l'utilisateur</param>
        /// <param name="rowVersion">Valeur anti-concurrence de la base de données</param>
        protected User(int id,
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

        #region Methodes

        /// <summary>
        /// Override de la méthode ToString pour afficher les informations d'un utilisateur
        /// </summary>
        /// <returns>Un string représentant l'utilisateur</returns>
        public override string ToString() {
            return $"#{this.Id} - {this.Username}";
        }
        public bool ValidateUsername(string username)
        {
            return username.Length <= USERNAME_MAX_LENGTH 
                && username.Length >= USERNAME_MIN_LENGTH;
        }

        public bool ValidatePasswordHash(string passwordHash)
        {
            return passwordHash.Length <= PASSWORDHASH_MAX_LENGTH;
        }

        public bool ValidatePassword(string password) {
            return password.Length <= PASSWORD_MAX_LENGTH 
                && password.Length >= PASSWORD_MIN_LENGTH;
        }

        // Méthodes pour determiner les roles d'un utilisateur
        public bool IsAdministrator()
        {
            foreach (Role role in this.Roles)
            {
                if (role.Id == Role.ADMIN_ROLE_ID)
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
                if(role.Id == Role.OFFICE_EMPLOYEE_ROLE_ID)
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
                if(role.Id == Role.WH_EMPLOYEE_ROLE_ID)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
