using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    /// <summary>
    /// Classe représentant un rôle
    /// </summary>
    public class Role
    {
        /// <summary>
        /// L'identifiant du rôle pour les administrateurs
        /// </summary>
        public const int ADMIN_ROLE_ID = 1;

        /// <summary>
        /// L'identifiant du rôle pour les employés de bureau
        /// </summary>
        public const int OFFICE_EMPLOYEE_ROLE_ID = 2;

        /// <summary>
        /// L'identifiant du rôle pour les employés d'entrepot
        /// </summary>
        public const int WH_EMPLOYEE_ROLE_ID = 3;

        /// <summary>
        /// Taille maximale pour le nom du rôle
        /// </summary>
        public const int ROLE_NAME_MAX_LENGTH = 64;

        /// <summary>
        /// Taille maximale pour la description du rôle
        /// </summary>
        public const int ROLE_DESCRIPTION_MAX_LENGTH = 255;

        // Identifiant du rôle 
        public int Id {  get; set; }

        // Données du rôle
        public string RoleName {  get; set; }
        public string RoleDescription { get; set; }

        // Meta-données
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; } = null!;

        // Propriétés de navigation EF Core
        public List<User> Users { get; set; } = new List<User>();

        /// <summary>
        /// Constructeur orienté création manuelle
        /// </summary>
        /// <param name="roleName">Le nom du rôle</param>
        /// <param name="roleDescription">La description du rôle</param>
        public Role(string roleName, string roleDescription)
        {
            this.RoleName = roleName;
            this.RoleDescription = roleDescription;
        }

        /// <summary>
        /// Constructeur orienté création par Entity Framework
        /// </summary>
        /// <param name="id">l'identifiant du rôle</param>
        /// <param name="roleName">Le nom du rôle</param>
        /// <param name="roleDescription">La description du rôle</param>
        /// <param name="dateCreated">La date de création du rôle</param>
        /// <param name="dateModified">La date de modification du rôle</param>
        /// <param name="dateDeleted">La date de suppression du rôle</param>
        /// <param name="rowVersion">Valeur anti-concurrence de la base de données</param>
        protected Role(int id,
            string roleName,
            string roleDescription,
            DateTime dateCreated,
            DateTime? dateModified,
            DateTime? dateDeleted,
            byte[] rowVersion) : this(roleName, roleDescription)
        {
            Id = id;
            DateCreated = dateCreated;
            DateModified = dateModified;
            DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
        }

        #region Méthodes

        /// <summary>
        /// Override de la méthode ToString pour afficher les informations d'un rôle
        /// </summary>
        /// <returns>Un string représentant le rôle</returns>
        public override string ToString() {
            return $"#{this.Id} - {this.RoleName} - {this.RoleDescription}";
        }
        public bool ValidateRoleName(string roleName)
        {
            return roleName.Length <= ROLE_NAME_MAX_LENGTH;
        }

        public bool ValidateRoleDescription(string roleDescription)
        {
            return roleDescription.Length <= ROLE_DESCRIPTION_MAX_LENGTH;
        }

        #endregion
    }
}
