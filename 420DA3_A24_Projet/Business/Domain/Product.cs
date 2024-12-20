namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Class représentant un Product
/// </summary>
public class Product {
    // Constants 
    /// <summary>
    /// Longueur Maximale du Product Name
    /// </summary>
    public const int PRODUCT_NAME_MAX_LENGTH = 50;
    /// <summary>
    /// Longueur Maximale de la description du produit
    /// </summary>
    public const int DESC_MAX_LENGTH = 256;
    /// <summary>
    /// Longueur Maximale du code UPC du produit
    /// </summary>
    public const int CODE_UPC_MAX_LENGTH = 12;
    /// <summary>
    /// Longueur Maximale du Picture Name du produit
    /// </summary>
    public const int PICTURE_NAME_MAX_LENGTH = 256;
    /// <summary>
    /// Longueur Maximale du supplier code du produit
    /// </summary>
    public const int SUPPLIER_CODE_MAX_LENGTH = 128;

    // Private properties 

    /// <summary>
    /// Champ privé pour le product name
    /// </summary>
    private string productName = null!;
    /// <summary>
    /// Champ privé pour la description du produit
    /// </summary>
    private string desc = null!;
    /// <summary>
    /// Champ privé pour le code UPC du produit
    /// </summary>
    private string codeUPC = null!;
    /// <summary>
    /// Champ privé pour le picture name du produit
    /// </summary>
    private string pictureName = null!;
    /// <summary>
    /// Champ privé pour le code du supplier
    /// </summary>
    private string supplierCode = null!;

    /// <summary>
    /// Le id du product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Le nom du produit
    /// </summary>
    public string ProductName {
        get {
            return this.productName;
        }
        set {
            this.productName = !ValidateProductName(value)
                ? throw new ArgumentOutOfRangeException($"Product Name must be under {PRODUCT_NAME_MAX_LENGTH} character!")
                : value;
        }
    }

    /// <summary>
    /// La description du produit
    /// </summary>
    public string Desc {
        get {
            return this.desc;
        }
        set {
            this.desc = !ValidateProductDesc(value)
                ? throw new ArgumentOutOfRangeException($"Product Desc must be under {DESC_MAX_LENGTH} characters!")
                : value;
        }
    }

    /// <summary>
    /// le code UPC du produit
    /// </summary>
    public string CodeUPC {
        get {
            return this.codeUPC;
        }
        set {
            this.codeUPC = !ValidateCodeUPC(value)
                ? throw new ArgumentOutOfRangeException($"Product Code UPC must be exactly {CODE_UPC_MAX_LENGTH} characters!")
                : value;
        }
    }

    /// <summary>
    /// Picture name du produit
    /// </summary>
    public string? PictureName {
        get {
            return this.pictureName;
        }
        set {
            this.pictureName = !ValidatePictureName(value)
                ? throw new ArgumentOutOfRangeException($"Product Picture Name must be under {PICTURE_NAME_MAX_LENGTH} characters!")
                : value;
        }
    }

    /// <summary>
    /// Le id du client
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Le id du supplier 
    /// </summary>
    public int SupplierId { get; set; }
    /// <summary>
    /// Le code du supplier
    /// </summary>
    public string SupplierCode {
        get {
            return this.supplierCode;
        }
        set {
            this.supplierCode = !ValidateSupplierCode(value)
                ? throw new ArgumentOutOfRangeException($"Product Supplier Code must be under {SUPPLIER_CODE_MAX_LENGTH} characters!")
                : value;
        }
    }
    /// <summary>
    /// La quantité actuel du produit
    /// </summary>
    public int Quantity { get; set; }
    /// <summary>
    /// La quantité visé du produit
    /// </summary>
    public int AimQuantity { get; set; }
    /// <summary>
    /// Le poid du produit en kg
    /// </summary>
    public double Weight { get; set; }
    /// <summary>
    /// Date de création du produit
    /// </summary>
    public DateTime DateCreated { get; set; }
    /// <summary>
    /// La date de modification du produit
    /// </summary>
    public DateTime? DateModified { get; set; }
    /// <summary>
    /// Le date de supression du produit
    /// </summary>
    public DateTime? DateDeleted { get; set; }
    /// <summary>
    /// Valeur anti-concurence de EF Core
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    // Propriété de navigation 
    /// <summary>
    /// Le supplier associé à ce produit
    /// </summary>
    public virtual Supplier Supplier { get; set; } = null!;
    /// <summary>
    /// Le client associé à ce produit
    /// </summary>
    public virtual Client Client { get; set; } = null!;

    /// <summary>
    /// La liste des achats de ce produit
    /// </summary>
    public virtual List<PurchaseOrder> PurchaseOrders { get; set; } = null!;
    /// <summary>
    /// La liste des ordres de shipping de ce produit
    /// </summary>
    public virtual List<ShippingOrderProduct> ShippingOrderProducts { get; set; } = null!;

    /// <summary>
    /// Constructeur manuelle 
    /// </summary>
    /// <param name="productName">le nom du produit</param>
    /// <param name="desc">la description du produit</param>
    /// <param name="codeUPC">le code upc du produit</param>
    /// <param name="clientId">le client id associé à ce produit</param>
    /// <param name="supplierId">le supplier id associé à ce produit</param>
    /// <param name="supplierCode">le code du supplier</param>
    /// <param name="quantity">la quantité actuel de ce produit</param>
    /// <param name="aimQuantity">la quantité visé de ce produit</param>
    /// <param name="weight">le poids de ce produit</param>
    /// <param name="pictureName">le nom de la picture de ce produit</param>
    public Product(string productName, string desc, string codeUPC, int clientId, int supplierId, string supplierCode, int quantity,
        int aimQuantity, double weight, string? pictureName = null) {
        this.ProductName = productName;
        this.Desc = desc;
        this.CodeUPC = codeUPC;
        this.ClientId = clientId;
        this.SupplierId = supplierId;
        this.SupplierCode = supplierCode;
        this.Quantity = quantity;
        this.AimQuantity = aimQuantity;
        this.Weight = weight;
        this.PictureName = pictureName;
    }

    /// <summary>
    /// Constructeur orienté création par Entity Framework
    /// </summary>
    /// <param name="productId">L'identifiant du produit</param>
    /// <param name="productName">le nom du produit</param>
    /// <param name="desc">la description du produit</param>
    /// <param name="codeUPC">le code upc du produit</param>
    /// <param name="clientId">le client id associé à ce produit</param>
    /// <param name="supplierId">le supplier id associé à ce produit</param>
    /// <param name="supplierCode">le code du supplier</param>
    /// <param name="quantity">la quantité actuel de ce produit</param>
    /// <param name="aimQuantity">la quantité visé de ce produit</param>
    /// <param name="weight">le poids de ce produit</param>
    /// <param name="dateCreated">la date de création du produit</param>
    /// <param name="dateModified">la date de la dernière modification du produit</param>
    /// <param name="dateDeleted">la date de suppression du produit</param>
    /// <param name="rowVersion">valeur anti-concurrence de la base de données</param>
    /// <param name="pictureName">le nom de la picture de ce produit</param>
    private Product(int productId, string productName, string desc, string codeUPC, int clientId, int supplierId, string supplierCode, int quantity,
        int aimQuantity, double weight, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion, string? pictureName = null)
        : this(productName, desc, codeUPC, clientId, supplierId, supplierCode, quantity, aimQuantity, weight, pictureName) {
        this.ProductId = productId;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    // Constructeur vide
    public Product() { }

    #region METHODES DE VERIFICATION
    /// <summary>
    /// Validation du nom de produit
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    static private bool ValidateProductName(string value) {
        return value.Length <= PRODUCT_NAME_MAX_LENGTH;
    }

    /// <summary>
    /// Validation de la description du produit
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    static private bool ValidateProductDesc(string value) {
        return value.Length <= DESC_MAX_LENGTH;
    }

    /// <summary>
    /// Validation du code UPC du produit
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    static private bool ValidateCodeUPC(string value) {
        return value.Length <= CODE_UPC_MAX_LENGTH;
    }

    /// <summary>
    /// Validation du picture name du produit
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    static private bool ValidatePictureName(string value) {
        return value.Length <= PICTURE_NAME_MAX_LENGTH || value == null;
    }

    /// <summary>
    /// Validation du supplier code du produit
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    static private bool ValidateSupplierCode(string value) {
        return value.Length <= SUPPLIER_CODE_MAX_LENGTH;
    }

    #endregion

    #region METHODES

    /// <summary>
    /// Override de la méthode ToString pour afficher les informations d'un prpduit
    /// </summary>
    /// <returns>Un string représentant un produit</returns>
    public override string ToString() {
        return $"#{this.ProductId} - {this.productName} | {this.Quantity}";
    }
    #endregion

}
