using System.ComponentModel.DataAnnotations;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Représente l'adresse des entrepôts ou des entreprises clientes.
/// Cette classe contient des informations sur l'adresse physique, notamment le type d'adresse, 
/// les détails spécifiques à l'adresse (numéro civique, rue, ville, etc.), ainsi que des métadonnées 
/// pour la gestion des enregistrements.
/// </summary>
public class Address {
    /// <summary>
    /// Longueur maximale de l'adresse
    /// </summary>
    public const int AddresseeMaxLength = 64;

    /// <summary>
    /// Longueur maximale du numéro civique 
    /// </summary>
    public const int CivicNumberMaxLength = 6;

    /// <summary>
    /// Longueur maximale de la rue
    /// </summary>
    public const int StreetMaxLength = 128;

    /// <summary>
    /// Longueur maximale de la ville
    /// </summary>
    public const int CityMaxLength = 64;

    /// <summary>
    /// Longueur maximale de l'état dans lequel il est situé
    /// </summary>
    public const int StateMaxLength = 64;

    /// <summary>
    /// Longueur maximale du pays dans lequel il est situé
    /// </summary>
    public const int CountryMaxLength = 64;

    /// <summary>
    /// Longueur maximale du code postal
    /// </summary>
    public const int PostalCodeMaxLength = 64;

    // Identifiants et données de l'adresse
    [Key]
    public int Id { get; set; }

    // Type de l'adresse (résidentielle, commerciale, etc.)
    [Required]
    public AddressTypeEnum AddressType { get; set; }

    // Données entrées par l'utilisateur


    // Adresse physique
    [MaxLength(AddresseeMaxLength)]
    public string Addresse {
        get {
            return this.Addresse;

        }
        set {
            if (!this.ValidateAddresse(value)) {
                throw new ArgumentException("Addresse", $"La longueur d' addresse doit être inférieur à {AddresseeMaxLength}");
            }

            this.Addresse = value;
        }

    }



    // Numéro civique 
    [MaxLength(CivicNumberMaxLength)]
    public string CivicNumber {
        get {
            return this.CivicNumber;

        }
        set {
            if (!this.ValidateCivicNumber(value)) {
                throw new ArgumentException("CivicNumber", $"La longueur de CivicNumber doit être inférieur à {CivicNumberMaxLength}");
            }

            this.CivicNumber = value;
        }

    }


    // Rue
    [MaxLength(StreetMaxLength)]
    public string Street {
        get {
            return this.Street;

        }
        set {
            if (!this.ValidateStreet(value)) {
                throw new ArgumentException("Street", $"La longueur de Street doit être inférieur à {StreetMaxLength}");
            }

            this.Street = value;
        }
    }

    // Ville
    [MaxLength(CityMaxLength)]
    public string City {
        get {
            return this.City;

        }
        set {
            if (!this.ValidateCity(value)) {
                throw new ArgumentException("City", $"La longueur de City doit être inférieur à {CityMaxLength}");
            }

            this.City = value;
        }
    }

    // État ou province 

    [MaxLength(StateMaxLength)]
    public string State {
        get {
            return this.State;

        }
        set {
            if (!this.ValidateState(value)) {
                throw new ArgumentException("State", $"La longueur de State doit être inférieur à {StateMaxLength}");
            }

            this.State = value;
        }
    }


    // Pays
    [MaxLength(CountryMaxLength)]
    public string Country {
        get {
            return this.Country;

        }
        set {
            if (!this.ValidateCountry(value)) {
                throw new ArgumentException("Country", $"La longueur de State doit être inférieur à {StateMaxLength}");
            }

            this.State = value;
        }
    }

    // Code postal
    [MaxLength(PostalCodeMaxLength)]
    public string PostalCode {
        get {
            return this.PostalCode;

        }
        set {
            if (!this.ValidatePostalCode(value)) {
                throw new ArgumentException("PostalCode", $"La longueur de Street doit être inférieur à {PostalCodeMaxLength}");
            }

            this.PostalCode = value;
        }
    }

    // Métadonnées pour la gestion des enregistrements

    // Date de création de l'adresse

    public DateTime DateCreated { get; set; }
    // Date de modification de l'adresse
    public DateTime? DateModified { get; set; }
    // Date de suppression de l'adresse
    public DateTime? DateDeleted { get; set; }

    // Version de ligne pour le contrôle de la concurrence optimiste
    [Timestamp]
    public byte[] RowVersion { get; set; } = null!;


    // Propriétés de navigation EF Core

    /// <summary>
    /// Liste des clients associés à cette adresse
    /// </summary>
    public List<Client> Clients { get; set; } = new List<Client>();

    /// <summary>
    /// Entrepôt propriétaire de cette adresse
    /// </summary>
    public virtual Warehouse OwnerWarehouse { get; set; } = null!;

    /// <summary>
    /// Commande d'expédition associée à l'adresse
    /// </summary>
    public virtual ShippingOrder OwnerShipOrder { get; set; } = null!;

    /// <summary>
    /// Constructeur pour créer une adresse avec les détails fournis.
    /// </summary>
    /// /// <param name="addressType">Type d'addresse </param>
    /// <param name="addresse"> L'addresse de l'emplacement </param>      
    /// <param name="civicNumber"> Numéro civique  de l'adresse</param>
    /// <param name="street"> Rue de l'addresse </param>
    /// <param name="city"> Ville de l'addresse </param>
    /// <param name="state"> État de l'adresse </param>
    /// <param name="country"> Pays de l'adresse </param>
    /// <param name="postalCode"> Code Postal de l'addresse</param>
    public Address(AddressTypeEnum addressType, string addresse, string civicNumber,
        string street, string city, string state,
        string country, string postalCode) {
        this.AddressType = addressType;
        this.Addresse = addresse;
        this.CivicNumber = civicNumber;
        this.Street = street;
        this.City = city;
        this.State = state;
        this.Country = country;
        this.PostalCode = postalCode;

    }

    protected Address(
        int id,
        AddressTypeEnum addressType,
        string addresse,
        string civicNumber,
        string street,
        string city,
        string state,
        string country,
        string postalCode,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(addressType, addresse, civicNumber, street, city, state, country, postalCode) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;

    }

    /// <summary>
    /// Enum pour représenter les types d'adresses
    /// </summary>
    public enum AddressTypeEnum {
        Residential, // Adresse résidentielle
        Commercial, // Adresse commerciale
        Shipping,   // Adresse d'expédition
        Billing     // Adresse de facturation
    }

    #region Methodes de validation et utilitaires
    /// <summary>
    /// Redéfinition de la méthode ToString pour afficher les détails d'une adresse.
    /// </summary>
    /// <returns>Une chaîne contenant l'ID et l'adresse.</returns>
    public override string ToString() {
        return $"#{this.Id} - {this.Addresse}";
    }

    /// <summary>
    /// Valide la longueur de l'adresse.
    /// </summary
    public bool ValidateAddresse(string address) {
        return address.Length <= AddresseeMaxLength;
    }

    /// <summary>
    /// Valide la longueur du numéro civique.
    /// </summary>
    public bool ValidateCivicNumber(string civicNumber) {
        return civicNumber.Length <= CivicNumberMaxLength;
    }

    /// <summary>
    /// Valide la longueur du numéro civique.
    /// </summary>
    public bool ValidateStreet(string street) {
        return street.Length <= StreetMaxLength;
    }

    /// <summary>
    /// Valide la longueur du numéro civique.
    /// </summary>
    public bool ValidateCity(string city) {
        return city.Length <= CityMaxLength;
    }

    /// <summary>
    /// Valide la longueur de l'état.
    /// </summary>
    public bool ValidateState(string state) {
        return state.Length <= StateMaxLength;
    }

    /// <summary>
    /// Valide la longueur du pays.
    /// </summary>
    public bool ValidateCountry(string country) {
        return country.Length <= CountryMaxLength;
    }

    /// <summary>
    /// Valide la longueur du code postal.
    /// </summary>
    public bool ValidatePostalCode(string postalCode) {
        return postalCode.Length <= PostalCodeMaxLength;
    }
    #endregion
}
