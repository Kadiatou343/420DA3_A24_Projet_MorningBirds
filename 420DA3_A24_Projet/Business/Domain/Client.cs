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

    public class Client
    {
        public const int ClientNameMaxLength = 128;
        public const int ContactFirstNameMaxLength = 32;
        public const int ContactLastNameMaxLength = 32;
        public const int ContactEmailMaxLength = 128;
        public const int ContactTelephoneMaxLength = 15;

        [Key]
        [Column("Id", TypeName = "int", Order = 0)]
        public int Id { get; set; }

        public string ClientName { get; set; }

        public int? WarehouseId { get; set; }
   
        public string ContactFirstName { get; set; }
       
        public string ContactLastName { get; set; }

        public string ContactEmail { get; set; }

        public string ContactTelephone { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }

        public byte[] RowVersion { get; set; } = null!;

       // [ForeignKey(nameof(WarehouseId))]
       //[DeleteBehavior(DeleteBehavior.SetNull)]

       //public Warehouse? AssignedWarehouse{ get; set; }

        /* en Attente des créations des classes

         public List<Product> Product { get; set; } = new List<Product>();

        public List<ShippingOrders> ShippingOrders{ get; set; } = new List<ShippingOrders>(); */

        public Client (string clientName, string contactFirstName, string contactLastName,
            string contactEmail, string contactTelephone, int? warehouseId)
        {
            this.ClientName = clientName;
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.ContactEmail = contactEmail;
            this.ContactTelephone = contactTelephone;
            this.WarehouseId = warehouseId;
        }

        protected Client(
            int id, 
            string clientName, 
            int? warehouseId,
            string contactFirstName, 
            string contactLastName, 
            string contactEmail, 
            string contactTelephone,
            DateTime dateCreated,
            DateTime? dateModified, 
            DateTime? dateDeleted,
            byte[] rowVersion)
           // Warehouse? assignedWarehouse)
            : this(clientName,contactFirstName,contactLastName,contactEmail, contactTelephone,warehouseId)
        {
            Id = id;
            ClientName = clientName;
            WarehouseId = warehouseId;
            ContactFirstName = contactFirstName;
            ContactLastName = contactLastName;
            ContactEmail = contactEmail;
            ContactTelephone = contactTelephone;
            DateCreated = dateCreated;
            DateModified = dateModified;
            DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
           // AssignedWarehouse = assignedWarehouse;
        }

        public bool ValidateCLientName(string clientName) 
            => clientName?.Length <= ClientNameMaxLength;
        public bool ValidateContactFirstName(string contactFirstName)
           => contactFirstName?.Length <= ContactFirstNameMaxLength;
        public bool ValidateContactLastName(string contactLastName)
           => contactLastName?.Length <= ContactLastNameMaxLength;
        public bool ValidateContactEmail(string contactEmail)
           => contactEmail?.Length <= ContactEmailMaxLength;
        public bool ValidateContactTelephone(string contactTelephone)
           => contactTelephone?.Length <= ContactTelephoneMaxLength;

    }

 
}
