using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class Role
    {
        public const int ADMIN_ROLE_ID = 1;
        public const int OFFICE_EMPLOYEE_ROLE_ID = 2;
        public const int WH_EMPLOYEE_ROLE_ID = 3;
        public const int ROLE_NAME_MAX_LENGTH = 64;
        public const int ROLE_DESCRIPTION_MAX_LENGTH = 255;

        public int Id {  get; set; }
        public string RoleName {  get; set; }
        public string RoleDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; } = null!;

        public List<User> Users { get; set; } = new List<User>();

        public Role(string roleName, string roleDescription)
        {
            this.RoleName = roleName;
            this.RoleDescription = roleDescription;
        }

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

        // Methodes de validation
        public bool ValidateRoleName(string roleName)
        {
            return roleName.Length <= ROLE_NAME_MAX_LENGTH;
        }

        public bool ValidateRoleDescription(string roleDescription)
        {
            return roleDescription.Length <= ROLE_DESCRIPTION_MAX_LENGTH;
        }
    }
}
