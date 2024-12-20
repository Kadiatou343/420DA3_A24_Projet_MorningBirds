﻿namespace _420DA3_A24_Projet.Business.Domain;
/// <summary>
/// Classe représentant un utilisateur 
/// </summary>
public class User {
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
    public const int PASSWORDHASH_MAX_LENGTH = 256;

    /// <summary>
    /// Longueur minimale du mot de passe de l'utilisateur
    /// </summary>
    public const int PASSWORD_MIN_LENGTH = 8;

    /// <summary>
    /// Longueur maximale du mot de passe de l'utilisateur
    /// </summary>
    public const int PASSWORD_MAX_LENGTH = 32;

    /// <summary>
    /// Champ privé pour le nom d'utilisateur
    /// </summary>
    private string username = null!;

    /// <summary>
    /// Champ privé pour le hash du mot de passe de l'utilisateur
    /// </summary>
    private string passwordHash = null!;

    /// <summary>
    /// L'identifiant de l'utilisateur
    /// </summary>
    public int Id { get; set; }

    // Données de l'utilisateur 

    /// <summary>
    /// Le nom d'utilisateur de l'utilisateur
    /// </summary>
    public string Username {
        get { return this.username; }
        set {
            if (!this.ValidateUsername(value)) {
                throw new ArgumentOutOfRangeException("Username", $"La longueur de Username devrait être inférieur à {USERNAME_MAX_LENGTH} ou supérieure à {USERNAME_MIN_LENGTH} !");
            }
            this.username = value;
        }
    }

    /// <summary>
    /// Le hash du mot de passe de l'utilisateur
    /// </summary>
    public string PasswordHash {
        get { return this.passwordHash; }
        set {
            if (!this.ValidatePasswordHash(value)) {
                throw new ArgumentOutOfRangeException("PasswordHash", $"La longueur de PasswordHash devrait être inférieur à {PASSWORDHASH_MAX_LENGTH} !");
            }
            this.passwordHash = value;
        }
    }

    /// <summary>
    /// L'identifiant de l'entrepôt associé à l'utilisateur s'il est un employé d'entrepôt
    /// </summary>
    public int? EmployeeWarehouseId { get; set; }

    /// <summary>
    /// Date de création de l'utilisateur
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Date de modification de l'utilisateur
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Date de suppression de l'utilisateur
    /// </summary>
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    /// Valeur anti-concurence de EF Core
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    // Proprietes de navigation EF Core

    /// <summary>
    /// L'entrepôt associé à cet utilisateur s'il est un employé d'entrepot
    /// </summary>
    public virtual Warehouse? EmployeeWarehouse { get; set; } = null;

    /// <summary>
    /// Les rôles associés à cet utilisateur 
    /// </summary>
    public virtual List<Role> Roles { get; set; } = new List<Role>();

    /// <summary>
    /// Les commandes d'expédition crées par cet utilisateur s'il est employé de bureau ou admin
    /// </summary>
    public virtual List<ShippingOrder> CreatedShipOrders { get; set; } = new List<ShippingOrder>();

    /// <summary>
    /// Les commandes d'expédition executées par cet utilisateur s'il est employé de bureau ou admin
    /// </summary>
    public virtual List<ShippingOrder> FulfilledShipOrders { get; set; } = new List<ShippingOrder>();


    /// <summary>
    /// Constructeur orienté création manuelle 
    /// </summary>
    /// <param name="username">Le nom d'utilisateur de l'utilisateur</param>
    /// <param name="passwordHash">Le Hash du mot de passe de l'utilisateur</param>
    /// <param name="employeeWarehouseId">L'identifiant de l'entrepôt associé à l'utilisateur s'il est un employé d'entrepot</param>

    public User(string username, string passwordHash, int? employeeWarehouseId = null) {
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
    /// <param name="employeeWarehouseId">L'identifiant de l'entrepôt associé à l'utilisateur s'il est un employé d'entrepot</param>
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
        byte[] rowVersion) : this(username, passwordHash, employeeWarehouseId) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #region Méthodes

    /// <summary>
    /// Override de la méthode ToString pour afficher les informations d'un utilisateur
    /// </summary>
    /// <returns>Un string représentant l'utilisateur</returns>
    public override string ToString() {
        return $"#{this.Id} - {this.Username}";
    }

    /// <summary>
    /// Valider le nom d'utilisateur
    /// </summary>
    /// <param name="username">La chaine à faire valider</param>
    /// <returns>Le résultat de la validation en bool</returns>
    public bool ValidateUsername(string username) {
        return username.Length <= USERNAME_MAX_LENGTH
            && username.Length >= USERNAME_MIN_LENGTH;
    }

    /// <summary>
    /// Valider le hash du mot de passe
    /// </summary>
    /// <param name="passwordHash">Le hash du mot de passe à faire valider</param>
    /// <returns>Le résultat de la validation en bool</returns>
    public bool ValidatePasswordHash(string passwordHash) {
        return passwordHash.Length <= PASSWORDHASH_MAX_LENGTH;
    }

    // Méthodes pour determiner les roles d'un utilisateur

    /// <summary>
    /// Determiner si l'utilisateur possède le rôle d'administrateur
    /// </summary>
    /// <returns>Le résultat de la verification en bool</returns>
    public bool IsAdministrator() {
        foreach (Role role in this.Roles) {
            if (role.Id == Role.ADMIN_ROLE_ID) {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Determiner si l'utilisateur possède le rôle d'employé de bureau
    /// </summary>
    /// <returns>Le résultat de la verification en bool</returns>
    public bool IsOfficeEmployee() {
        foreach (Role role in this.Roles) {
            if (role.Id == Role.OFFICE_EMPLOYEE_ROLE_ID) {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Determiner si l'utilisateur possède le rôle d'employé d'entrepôt
    /// </summary>
    /// <returns>Le résultat de la verification en bool</returns>
    public bool IsWarehouseEmployee() {
        foreach (Role role in this.Roles) {
            if (role.Id == Role.WH_EMPLOYEE_ROLE_ID) {
                return true;
            }
        }
        return false;
    }

    #endregion
}
