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
    internal class Address
    {
        public const int AddresseeMaxLength = 64;
        public const int CivicNumberMaxLength = 6;
        public const int StreetMaxLength = 128;
        public const int CityMaxLength = 64;
        public const int StateMaxLength = 64;
        public const int CountryMaxLength = 64;
        public const int PostalCodeMaxLength = 64;

        [Key]
        [Column("Id", TypeName = "int", Order = 0)]
        public int Id { get; set; }

        //public string AddressType { get; set; }

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

        //public Warehouse? OwnerWarehouse{ get; set; }  
        //public ShippingOrder? OwnerShipOrder{ get; set; }

       

       public Address(string addresse, string civicNumber, 
           string street, string city, string state,
           string country, string postalCode)
        {
            Addresse = addresse;
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
         // Warehouse? ownerWarehouse,
        // ShippingOrder? ownerShipOrder)
          :this(addresse, civicNumber,street, city,state,country,postalCode)
      {
            Id = id;
            Addresse = addresse;
            CivicNumber = civicNumber;
            Street = street;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
            DateCreated = dateCreated;
            DateModified = dateModified;
            DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
             //OwnerWarehouse = ownerWarehouse;
          // OwnerShipOrder = ownerShipOrder;
        }

        public bool ValidateCivicNumber(string civicNumber)
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

    }
}
