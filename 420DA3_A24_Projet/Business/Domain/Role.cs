namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un rôle
/// </summary>
public class Role {
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

    /// <summary>
    /// Champ privé pour le nom du rôle
    /// </summary>
    private string roleName = null!;

    /// <summary>
    /// Champ privé pour la description du rôle
    /// </summary>
    private string roleDescription = null!;

    /// <summary>
    /// L'identifiant du rôle
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Le nom du rôle
    /// </summary>
    public string RoleName {
        get {
            return this.roleName;
        }
        set {
            if (!this.ValidateRoleName(value)) {
                throw new ArgumentOutOfRangeException("RoleName", $"La longueur de RoleName devrait être inférieur à {ROLE_NAME_MAX_LENGTH} !");
            }
            this.roleName = value;
        }
    }

    /// <summary>
    /// La description du rôle
    /// </summary>
    public string RoleDescription {
        get {
            return this.roleDescription;
        }
        set {
            if (!this.ValidateRoleDescription(value)) {
                throw new ArgumentOutOfRangeException("RoleDescription", $"La longueur de RoleDescription devrait être inférieur à {ROLE_DESCRIPTION_MAX_LENGTH} !");
            }
            this.roleDescription = value;
        }
    }

    /// <summary>
    /// La date de création du rôle
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// La date de modification du rôle
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// La date de suppression du rôle
    /// </summary>
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    /// Valeur anti-concurrence EF Core
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    // Propriétés de navigation EF Core

    /// <summary>
    /// La liste de tous les utilisateurs ayant ce rôle
    /// </summary>
    public virtual List<User> Users { get; set; } = new List<User>();

    /// <summary>
    /// Constructeur orienté création manuelle
    /// </summary>
    /// <param name="roleName">Le nom du rôle</param>
    /// <param name="roleDescription">La description du rôle</param>
    public Role(string roleName, string roleDescription) {
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
        byte[] rowVersion) : this(roleName, roleDescription) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
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

    /// <summary>
    /// Valider le nom du rôle
    /// </summary>
    /// <param name="roleName">Le nom à faire valider</param>
    /// <returns>Le résultat de la verification en bool</returns>
    public bool ValidateRoleName(string roleName) {
        return roleName.Length <= ROLE_NAME_MAX_LENGTH;
    }

    /// <summary>
    /// Valider la description du rôle
    /// </summary>
    /// <param name="roleDescription">La description à faire valider</param>
    /// <returns>Le résultat de la verification en bool</returns>
    public bool ValidateRoleDescription(string roleDescription) {
        return roleDescription.Length <= ROLE_DESCRIPTION_MAX_LENGTH;
    }

    #endregion
}
