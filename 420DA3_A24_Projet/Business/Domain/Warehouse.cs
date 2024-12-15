namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un entrêpot 
/// </summary>
public class Warehouse {
    /// <summary>
    /// Longeur maximale de nom d'entrepôt
    /// </summary>
    public const int WAREHOUSE_NAME_MAX_LENGTH = 128;

    private readonly string warehouseName = null!;

    //Attributs

    public int Id { get; set; }

    // Données de l'entrepôt
    public string WareHouseName {
        get { return this.warehouseName; }
        set {
            if (!this.ValidateWarehouseName(value)) {
                throw new ArgumentOutOfRangeException("WareHouseName", $"La longueur de Warehousename devrait être inférieur à {WAREHOUSE_NAME_MAX_LENGTH}!");
            }
        }
    }

    public int AddressId { get; set; }

    // Meta-donnees 
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }

    public byte[] RowVersion { get; set; } = null!;

    // Propriétés de navigation EF Core

    /// <summary>
    /// Les clients associés à cet entrepôt
    /// </summary>
    public virtual List<Client> Clients { get; set; } = new List<Client>();
    /// <summary>
    /// Objet de class Address associé à chaque entrepôt
    /// </summary>

    public virtual Address Adresse { get; set; }
    /// <summary>
    /// Liste de PurchaseOrder assocìé à l'entrepôt
    /// </summary>
    public virtual List<PurchaseOrder> RestockOrders { get; set; } = new List<PurchaseOrder>();

    /// <summary>
    /// Liste des employés d'entrepôt associés à chaque entrepôt
    /// </summary>
    public virtual List<User> WarehouseEmployees { get; set; } = new List<User>();

    /// <summary>
    /// Constructeur orienté création manuelle
    /// </summary>
    /// <param name="wareHouseName">Nom de l'entrepôt</param>
    /// <param name="adressId">L'identification de l'addresse associé à l'entrepôt</param>

    public Warehouse(string wareHouseName, int adressId) {
        this.WareHouseName = wareHouseName;
        this.AddressId = adressId;
    }

    /// <summary>
    /// Constructeur orienté création par Entity Framework 
    /// </summary>
    /// <param name="id">Identificant de l'entrepôt</param>
    /// <param name="wareHouseName">Nom de l'entrepôt</param>
    /// <param name="adressId">L'identification de l'addresse associé à l'entrepôt</param>
    /// <param name="dateCreated">Date de création de l'entrepôt dans la BD</param>
    /// <param name="dateModified">Date de modification de l'entrepôt dans la BD</param>
    /// <param name="dateDeleted">Date de suppresion de l'entrepôt dans la BD</param>
    /// <param name="rowVersion">Valeur anti-concurrence de la base de données</param>

    protected Warehouse(
        int id,
        string wareHouseName,
        int adressId,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion) : this(wareHouseName, adressId) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #region Methodes

    /// <summary>
    /// Override de la méthode ToString pour afficher les informations d'un entrepôt
    /// </summary>
    /// <returns>Un string représentant l'entrepôt</returns>
    public override string ToString() {
        return $"#{this.Id} - {this.WareHouseName}";
    }
    //Methodes de validation de longeur nom d'entrepôt
    public bool ValidateWarehouseName(string warehouseName) {
        return warehouseName.Length <= WAREHOUSE_NAME_MAX_LENGTH;
    }

    #endregion
}
