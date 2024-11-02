using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class Supplier
    {
        // Constante
        public const int SUPPLIER_NAME_MAX_LENGTH = 128;
        public const int CONTACT_NAME_MAX_LENGTH = 64;
        public const int CONTACT_EMAIL_MAX_LENGTH = 64;
        public const int CONTACT_PHONE_MAX_LENGTH = 10;

        // Propriété des Fournisseurs
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public List<Product> Products { get; set; } = new List<Product>();

        // Constructeur
        public Supplier(string supplierName, string contactLastName, string contactFirstName, string contactEmail, string contactPhone) { 
            this.SupplierName = supplierName;
            this.ContactLastName = contactLastName;
            this.ContactFirstName = contactFirstName;
            this.ContactEmail = contactEmail;
            this.ContactPhone = contactPhone;
        }

        // Constructeur BD
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
            byte[] rowVersion) : this(supplierName, contactLastName, contactFirstName, contactEmail, contactPhone)
        {
            this.SupplierId = supplierId;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
        }

    }
}
