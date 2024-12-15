namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant l'adresse des entrepôts, de l'entreprise Cliente
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

    // Identifiants
    public int Id { get; set; }

    // Donnée entrée par l'utiliasteur
    // en cours ...

    public string AddressType { get; set; }

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



    //Meta-données
    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }

    public byte[] RowVersion { get; set; } = null!;


    // Propriétés de navigation EF Core

    /// <summary>
    ///  Addresse des clients
    /// </summary>
    public List<Client> Clients { get; set; } = new List<Client>();

    /// <summary>
    /// Addresse des entrepots
    /// </summary>
    public virtual Warehouse OwnerWarehouse { get; set; } = null!;

    /// <summary>
    ///  Addresse d'expédition
    /// </summary>
    public virtual ShippingOrder OwnerShipOrder { get; set; } = null!;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="addresse"> Addresse de l'emplacement </param>
    /// <param name="addresstype">Type d'addresse </param>
    /// <param name="civicNumber"> Numéro civique </param>
    /// <param name="street"> Rue de l'addresse </param>
    /// <param name="city"> Ville de l'addresse </param>
    /// <param name="state"> État de l'adresse </param>
    /// <param name="country"> Pays de l'adresse </param>
    /// <param name="postalCode"> Code Postal de l'addresse</param>
    public Address(string addresse, string addresstype, string civicNumber,
       string street, string city, string state,
       string country, string postalCode) {
        this.Addresse = addresse;
        this.AddressType = addresstype;
        this.CivicNumber = civicNumber;
        this.Street = street;
        this.City = city;
        this.State = state;
        this.Country = country;
        this.PostalCode = postalCode;

    }

    protected Address(
        int id,
        string addresse,
        string addresstype,
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
        : this(addresse, addresstype, civicNumber, street, city, state, country, postalCode) {
        this.Id = id;
        this.Addresse = addresse;
        this.AddressType = addresstype;
        this.CivicNumber = civicNumber;
        this.Street = street;
        this.City = city;
        this.State = state;
        this.Country = country;
        this.PostalCode = postalCode;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }
    #region Methodes
    /// <summary>
    /// Override de la méthode ToString pour afficher les details d'une addresse 
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
        return $"#{this.Id} - {this.Addresse}";
    }

    public bool ValidateAddresse(string address) {
        return address.Length <= AddresseeMaxLength;
    }
    public bool ValidateCivicNumber(string civicNumber) {
        return civicNumber.Length <= CivicNumberMaxLength;
    }

    public bool ValidateStreet(string street) {
        return street.Length <= StreetMaxLength;
    }
    public bool ValidateCity(string city) {
        return city.Length <= CityMaxLength;
    }
    public bool ValidateState(string state) {
        return state.Length <= StateMaxLength;
    }
    public bool ValidateCountry(string country) {
        return country.Length <= CountryMaxLength;
    }
    public bool ValidatePostalCode(string postalCode) {
        return postalCode.Length <= PostalCodeMaxLength;
    }
    #endregion
}
