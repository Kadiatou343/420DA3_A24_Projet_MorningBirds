namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Class représentant un Supplier
/// </summary>
public class Supplier {
    // Constantes
    /// <summary>
    /// La longueur maximum du nom d'un supplier
    /// </summary>
    public const int SUPPLIER_NAME_MAX_LENGTH = 128;
    /// <summary>
    /// La longueur maximum du last name et first name du contact d'un supplier
    /// </summary>
    public const int CONTACT_NAME_MAX_LENGTH = 64;
    /// <summary>
    /// La longueur maximum du email du contact d'un supplier
    /// </summary>
    public const int CONTACT_EMAIL_MAX_LENGTH = 64;
    /// <summary>
    /// Le longueur maximum du numero de téléphone du contact d'un supplier
    /// </summary>
    public const int CONTACT_PHONE_MAX_LENGTH = 10;

    // Private properties
    /// <summary>
    /// Champ privé pour le nom d'un supplier
    /// </summary>
    private string supplierName = null!;
    /// <summary>
    /// Champ privé pour le last name du contact d'un supplier
    /// </summary>
    private string contactLastName = null!;
    /// <summary>
    /// Champ privé pour le first name du contact d'un supplier
    /// </summary>
    private string contactFirstName = null!;
    /// <summary>
    /// Champ privé pour le email du contact d'un supplier
    /// </summary>
    private string contactEmail = null!;
    /// <summary>
    /// Champ privé pour le numéro de téléphone du contact d'un supplier
    /// </summary>
    private string contactPhone = null!;

    // Propriété des Fournisseurs
    /// <summary>
    /// L'identifiant d'un supplier
    /// </summary>
    public int SupplierId { get; set; }
    /// <summary>
    /// Le nom d'un supplier
    /// </summary>
    public string SupplierName {
        get {
            return this.supplierName;
        }
        set {
            this.supplierName = !ValidateSupplierName(value)
                ? throw new ArgumentOutOfRangeException($"Supplier Name must be under {SUPPLIER_NAME_MAX_LENGTH} characters!")
                : value;
        }
    }
    /// <summary>
    /// Last Name du contact d'un supplier 
    /// </summary>
    public string ContactLastName {
        get {
            return this.contactLastName;
        }
        set {
            this.contactLastName = !ValidateContactName(value)
                ? throw new ArgumentOutOfRangeException($"Supplier Contact Last Name must be under {CONTACT_NAME_MAX_LENGTH} characters!")
                : value;
        }
    }
    /// <summary>
    /// Le fist name du contact d'un supplier
    /// </summary>
    public string ContactFirstName {
        get {
            return this.contactFirstName;
        }
        set {
            this.contactFirstName = !ValidateContactName(value)
                ? throw new ArgumentOutOfRangeException($"Supplier Contact First Name must be under {CONTACT_NAME_MAX_LENGTH} characters!")
                : value;
        }
    }
    /// <summary>
    /// Le email du contact d'un supplier
    /// </summary>
    public string ContactEmail {
        get {
            return this.contactEmail;
        }
        set {
            this.contactEmail = !ValidateContactEmail(value)
                ? throw new ArgumentOutOfRangeException($"Supplier Contact Email must be under {CONTACT_EMAIL_MAX_LENGTH} characters!")
                : value;
        }
    }
    /// <summary>
    /// Le numero de téléphone du contact d'un supplier
    /// </summary>
    public string ContactPhone {
        get {
            return this.contactPhone;
        }
        set {
            this.contactPhone = !ValidateContactPhone(value)
                ? throw new ArgumentOutOfRangeException($"Supplier Contact Phone must be under {CONTACT_PHONE_MAX_LENGTH} characters!")
                : value;
        }
    }
    /// <summary>
    /// La date de création d'un supplier
    /// </summary>
    public DateTime DateCreated { get; set; }
    /// <summary>
    /// La date de la derniere modification d'un supplier
    /// </summary>
    public DateTime? DateModified { get; set; }
    /// <summary>
    /// La date de suppression d'un supplier
    /// </summary>
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    /// Valeur anti-concurence de EF Core
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;
    /// <summary>
    /// La liste des produits associé à ce supplier
    /// </summary>
    public List<Product> Products { get; set; } = new List<Product>();

    /// <summary>
    /// Constructeur manuelle
    /// </summary>
    /// <param name="supplierName">Le nom du supplier</param>
    /// <param name="contactLastName">le last name du contact du supplier</param>
    /// <param name="contactFirstName">le first name du contact du supplier</param>
    /// <param name="contactEmail">le email du contact du supplier</param>
    /// <param name="contactPhone">le numero de telephone du contact du supplier</param>
    public Supplier(string supplierName, string contactLastName, string contactFirstName, string contactEmail, string contactPhone) {
        this.SupplierName = supplierName;
        this.ContactLastName = contactLastName;
        this.ContactFirstName = contactFirstName;
        this.ContactEmail = contactEmail;
        this.ContactPhone = contactPhone;
    }

    /// <summary>
    /// Constructeur orienté création par Entity Framework
    /// </summary>
    /// <param name="supplierId">L'identifiant du supplier</param>
    /// <param name="supplierName">Le nom du supplier</param>
    /// <param name="contactLastName">le last name du contact du supplier</param>
    /// <param name="contactFirstName">le first name du contact du supplier</param>
    /// <param name="contactEmail">le email du contact du supplier</param>
    /// <param name="contactPhone">le numero de telephone du contact du supplier</param>
    /// <param name="dateCreated">la date de création du supplier</param>
    /// <param name="dateModified">la date de la derniere modification du supplier</param>
    /// <param name="dateDeleted">la date de suppression du supplier</param>
    /// <param name="rowVersion">valeur anti-concurrence de la base de données</param>
    private Supplier(
        int supplierId,
        string supplierName,
        string contactLastName,
        string contactFirstName,
        string contactEmail,
        string contactPhone,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion) : this(supplierName, contactLastName, contactFirstName, contactEmail, contactPhone) {
        this.SupplierId = supplierId;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    // Constructeur vide
    public Supplier() { }

    #region METHODES DE VALIDATION
    /// <summary>
    /// Validation du nom d'un supplier
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    private static bool ValidateSupplierName(string value) {
        return value.Length <= SUPPLIER_NAME_MAX_LENGTH;
    }

    /// <summary>
    /// Validation du last et first name du contact d'un supplier
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    private static bool ValidateContactName(string value) {
        return value.Length <= CONTACT_NAME_MAX_LENGTH;
    }

    /// <summary>
    /// Validation du email du contact d'un supplier
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    private static bool ValidateContactEmail(string value) {
        return value.Length <= CONTACT_EMAIL_MAX_LENGTH;
    }

    /// <summary>
    /// Validation du numero de téléphone du contact d'un supplier
    /// </summary>
    /// <param name="value">la valeur que l'on souhaite assigner</param>
    /// <returns>vrai si la validtion passe</returns>
    private static bool ValidateContactPhone(string value) {
        return value.Length <= CONTACT_PHONE_MAX_LENGTH;
    }
    #endregion

    #region METHODES
    /// <summary>
    /// Override de la méthode ToString pour afficher les informations d'un supplier
    /// </summary>
    /// <returns>Un string représentant un supplier</returns>
    public override string ToString() {
        return $"#{this.SupplierId} - {this.supplierName}";
    }

    #endregion

}
