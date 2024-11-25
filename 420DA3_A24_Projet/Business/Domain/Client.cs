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
    ///  Classe représentant l'entreprise cliente
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Longueur maxiamle du nom de l'entreprise
        /// </summary>
        public const int ClientNameMaxLength = 128;

        /// <summary>
        /// Longueur maxiamle du nom de la personne à contacter au dans de l'entrprise
        /// </summary>
        public const int ClientNameMinLength = 5;

        /// <summary>
        /// Longueur maximale du nom de la personne à contacter au dans de l'entrprise
        public const int ContactFirstNameMaxLength = 32;

        /// <summary>
        ///  Longueur maximale du prenom  de la personne à contacter au dans de l'entrprise
        /// </summary>
        public const int ContactLastNameMaxLength = 32;

        /// <summary>
        /// Longueur de l'email de l'entreprise
        /// </summary>
        public const int ContactEmailMaxLength = 128;

        /// <summary>
        /// Longueur du numéro de télephone de l'entreprise
        /// </summary>
        public const int ContactTelephoneMaxLength = 15;

       // Identifiants
        public int Id { get; set; }

        // Donnée entrée par l'utiliateur
        public string ClientName { 
            get
            {
                return this.ClientName;

            }
            set 
            {
                if (!this.ValidateCLientName(value)) {
                    throw new ArgumentException("ClientName", $"La longueur de ClientName doit entre{ClientNameMinLength} et {ClientNameMaxLength}");
                }  
                
                this.ClientName = value;
            } 
        }

        public int WarehouseId { get; set; }
   
        public string ContactFirstName {
            get {
                return this.ContactFirstName;

            }
            set {
                if (!this.ValidateContactFirstName(value)) {
                    throw new ArgumentException("ContactFirstName", $"La longueur de ContactFirstName doit être inférieur à {ContactFirstNameMaxLength}");
                }

                this.ContactFirstName = value;
            }
        }
        public string ContactLastName {
            get {
                return this.ContactLastName;

            }
            set {
                if (!this.ValidateContactLastName(value)) {
                    throw new ArgumentException("ContactLastName", $"La longueur de ContactLastName doit être inférieur à {ContactLastNameMaxLength}");
                }

                this.ContactLastName = value;
            }
        }

        public string ContactEmail {
            get {
                return this.ContactEmail;

            }
            set {
                if (!this.ValidateContactEmail(value)) {
                    throw new ArgumentException("ContactEmail", $"La longueur de l'email doit être inférieur à {ContactEmailMaxLength}");
                }

                this.ContactEmail = value;
            }
        }

        public string ContactTelephone {
            get {
                return this.ContactTelephone;

            }
            set {
                if (!this.ValidateContactTelephone(value)) {
                    throw new ArgumentException("ContactTelephone", $"La longueur ddu numéro de téléphone doit être inférieur à {ContactTelephoneMaxLength}");
                }

                this.ContactTelephone = value;
            }
        }

        //Meta-données
        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }

        public byte[] RowVersion { get; set; } = null!;


        // Propriétés de navigation EF Core

        /// <summary>
        /// Entrepôt assigné au client
        /// </summary>
        public virtual Warehouse AssignedWarehouse { get; set; } = null!;

        /// <summary>
        /// Addresses d'entreprises clientes
        /// </summary>
        public virtual List<Address> Addresses { get; set; } = new List<Address>();

        /// <summary>
        /// Produits appartenant à l'entreprise 
        /// </summary>
        public virtual List<Product> Products { get; set; } = new List<Product>();
         
        /// <summary>
        /// expedition des produits du fournisseurs vers l'entrepôt
        /// </summary>
        public virtual List<ShippingOrder> ShippingOrders { get; set; } = new List<ShippingOrder>();

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="clientName"> Nom de l'entreprise</param>
        /// <param name="contactFirstName">Nom de celui à contacter dans l'entrepise</param>
        /// <param name="contactLastName">prenom de celui à contacter dans l'entrepise</param>
        /// <param name="contactEmail">Boite mail de l'entreprise</param>
        /// <param name="contactTelephone">Numéro de téléphone de l'entraprise</param>
        /// <param name="warehouseId">Identifienat du fournisseur associé aux client</param>
        public Client (string clientName, string contactFirstName, string contactLastName,
            string contactEmail, string contactTelephone, int warehouseId)
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
            int assignedwarehouseId,
            string contactFirstName, 
            string contactLastName, 
            string contactEmail, 
            string contactTelephone,
            DateTime dateCreated,
            DateTime? dateModified, 
            DateTime? dateDeleted,
            byte[] rowVersion)
            : this(clientName,contactFirstName,contactLastName,contactEmail, contactTelephone,assignedwarehouseId)
        {
            this.Id = id;
            this.ClientName = clientName;
            this.WarehouseId = assignedwarehouseId;
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.ContactEmail = contactEmail;
            this.ContactTelephone = contactTelephone;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
            
        }

        #region Methodes

        /// <summary>
        /// Override de la méthode ToString pour afficher les informations d'un client
        /// </summary>
        /// <returns>un String représentant le client </returns>     

        public bool ValidateCLientName(string clientName) 
        { 
            return clientName.Length <= ClientNameMaxLength && clientName.Length >= ClientNameMinLength;
        }

        public bool ValidateContactFirstName(string contactFirstName) 
        {
            return contactFirstName.Length <= ContactFirstNameMaxLength && contactFirstName.Length >= ClientNameMinLength;
        } 
        public bool ValidateContactLastName(string contactLastName) 
        {
            return  contactLastName.Length <= ContactLastNameMaxLength && contactLastName.Length >= ClientNameMinLength;
        }
         
        public bool ValidateContactEmail(string contactEmail) 
        {
            return  contactEmail.Length <= ContactEmailMaxLength;
        }
        public bool ValidateContactTelephone(string contactTelephone) 
        {
            return  contactTelephone.Length <= ContactEmailMaxLength;        }

        #endregion
    }


}
