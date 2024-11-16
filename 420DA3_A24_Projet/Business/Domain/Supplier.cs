using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class Supplier
    {
        // Constantes
        public const int SUPPLIER_NAME_MAX_LENGTH = 128;
        public const int CONTACT_NAME_MAX_LENGTH = 64;
        public const int CONTACT_EMAIL_MAX_LENGTH = 64;
        public const int CONTACT_PHONE_MAX_LENGTH = 10;

        // Private properties
        private string supplierName = null!;
        private string contactLastName = null!;
        private string contactFirstName = null!;
        private string contactEmail = null!;
        private string contactPhone = null!;

        // Propriété des Fournisseurs
        public int SupplierId { get; set; }
        public string SupplierName { get {
                return this.supplierName;
            } set {
                this.supplierName = !ValidateSupplierName(value)
                    ? throw new ArgumentOutOfRangeException($"Supplier Name must be under {SUPPLIER_NAME_MAX_LENGTH} characters!")
                    : value;
            } }
        public string ContactLastName { get {
                return this.contactLastName;
            } set {
                this.contactLastName = !ValidateContactName(value)
                    ? throw new ArgumentOutOfRangeException($"Supplier Contact Last Name must be under {CONTACT_NAME_MAX_LENGTH} characters!")
                    : value;
            } }
        public string ContactFirstName { get {
                return this.contactFirstName;
            } set {
                this.contactFirstName = !ValidateContactName(value)
                    ? throw new ArgumentOutOfRangeException($"Supplier Contact First Name must be under {CONTACT_NAME_MAX_LENGTH} characters!")
                    : value;
            } }
        public string ContactEmail { get {
                return this.contactEmail;
            } set {
                this.contactEmail = !ValidateContactEmail(value)
                    ? throw new ArgumentOutOfRangeException($"Supplier Contact Email must be under {CONTACT_EMAIL_MAX_LENGTH} characters!")
                    : value;
            } }
        public string ContactPhone { get {
                return this.contactPhone;
            } set {
                this.contactPhone = !ValidateContactPhone(value)
                    ? throw new ArgumentOutOfRangeException($"Supplier Contact Phone must be under {CONTACT_PHONE_MAX_LENGTH} characters!")
                    : value;
            } }
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

        #region METHODES DE VALIDATION
        private static bool ValidateSupplierName(string value) {
            return value <= SUPPLIER_NAME_MAX_LENGTH;
        }

        private static bool ValidateContactName(string value) {
            return value <= CONTACT_NAME_MAX_LENGTH;
        }

        private static bool ValidateContactEmail(string value) {
            return value <= CONTACT_EMAIL_MAX_LENGTH;
        }

        private static bool ValidateContactPhone(string value) {
            return value <= CONTACT_PHONE_MAX_LENGTH
        }
        #endregion

        #region METHODES
        public override string ToString() {
            return $"#{this.SupplierId} - {this.supplierName}";
        }

        #endregion

    }
}
