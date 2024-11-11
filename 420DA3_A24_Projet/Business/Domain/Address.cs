using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    /// <summary>
    /// Classe représentant l'adresse des entrepôts, de l'entreprise Cliente
    /// </summary>
    public class Address
    {
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
        public const int StateMaxLength = 64 ;

        /// <summary>
        /// Longueur maximale du pays dans lequel il est situé
        /// </summary>
        public const int CountryMaxLength = 64;

        /// <summary>
        /// Longueur maximale du code postal
        /// </summary>
        public const int PostalCodeMaxLength = 64 ;

       // Identifiants
        public int Id { get; set; }

        // Donnée entrée par l'utiliasteur
         // en cours ...
              
        public string AddressType { get; set; }

        public string Addresse { get; set; }

        public string CivicNumber { get; set; }

        public string Street { get; set; }

        public string City{ get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

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
        public virtual Warehouse OwnerWarehouse { get; set; }

        /// <summary>
        ///  Addresse d'expédition
        /// </summary>
        public virtual ShippingOrder OwnerShipOrder { get; set; }

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
        public Address(string addresse,string addresstype, string civicNumber, 
           string street, string city, string state,
           string country, string postalCode)
        {
            Addresse = addresse;
            AddressType = addresstype;
            CivicNumber = civicNumber;
            Street = street;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
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
          :this(addresse, addresstype, civicNumber, street, city, state, country, postalCode)
      {
            this.Id = id;
            this.Addresse = addresse;
            this. AddressType = addresstype;
            this. CivicNumber = civicNumber;
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
        // en cours ...
        /*public bool ValidateCivicNumber(string civicNumber)
            => civicNumber?.Length <= CivicNumberMaxLength;
        public bool ValidateStreet(string street)
           => street.Length <= StreetMaxLength;
        public bool ValidateContactLastName(string city)
           => city.Length <= CityMaxLength;
        public bool ValidateState(string state)
           => state.Length <= StateMaxLength;
        public bool ValidateCountry(string country)
           => country.Length <= CountryMaxLength;
        public bool ValidatePostalCode (string postalCode)
            => postalCode.Length <= PostalCodeMaxLength;
        */
        #endregion
    }


}
