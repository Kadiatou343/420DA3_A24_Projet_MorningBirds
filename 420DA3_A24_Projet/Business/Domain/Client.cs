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
    /// Classe représentant un client, qui correspond à une entreprise ayant des relations commerciales.
    /// </summary>
    public class Client
    {
        // Constants pour les longueurs maximales et minimales des propriétés

        /// <summary>
        /// Longueur maximale du nom de l'entreprise.
        /// </summary>
        public const int ClientNameMaxLength = 128;

        /// <summary>
        /// Longueur minimale du nom de l'entreprise.
        /// </summary>
        public const int ClientNameMinLength = 5;

        /// <summary>
        /// Longueur maximale du prénom de la personne à contacter.
        /// </summary>
        public const int ContactFirstNameMaxLength = 32;

        /// <summary>
        /// Longueur maximale du nom de la personne à contacter.
        /// </summary>
        public const int ContactLastNameMaxLength = 32;

        /// <summary>
        /// Longueur maximale de l'adresse e-mail du contact.
        /// </summary>
        public const int ContactEmailMaxLength = 128;

        /// <summary>
        /// Longueur maximale du numéro de téléphone de l'entreprise.
        /// </summary>
        public const int ContactTelephoneMaxLength = 15;

        // Propriétés principales

        /// <summary>
        /// Identifiant unique du client (clé primaire).
        /// </summary>
        
        [Key]
        public int Id { get; set; }

        // <summary>
        /// Nom de l'entreprise cliente.
        /// </summary>
        /// 
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

        /// <summary>
        /// Identifiant de l'entrepôt associé au client.
        /// </summary>
        public int WarehouseId { get; set; }


        /// <summary>
        /// Prénom de la personne à contacter dans l'entreprise cliente.
        /// </summary>
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

        /// <summary>
        /// Prénom de la personne à contacter dans l'entreprise cliente.
        /// </summary>
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

        /// <summary>
        /// Adresse e-mail du contact de l'entreprise cliente.
        /// </summary>
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

        /// <summary>
        /// Numéro de téléphone du contact de l'entreprise cliente.
        /// </summary>
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

        /// <summary>
        /// Date de création de l'enregistrement.
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;


        /// <summary>
        /// Date de dernière modification (nullable).
        /// </summary>
        public DateTime? DateModified { get; set; }


        /// <summary>
        /// Date de suppression logique (nullable).
        /// </summary>
        public DateTime? DateDeleted { get; set; }


        /// <summary>
        /// Version de ligne pour la gestion des concurrences.
        /// </summary>
        public byte[] RowVersion { get; set; } = null!;


        // Propriétés de navigation EF Core

        /// <summary>
        /// Entrepôt assigné au client
        /// </summary>
        public virtual Warehouse AssignedWarehouse { get; set; } = null!;

        /// <summary>
        /// Liste des adresses associées à l'entreprise cliente.
        /// </summary>
        public virtual List<Address> Addresses { get; set; } = new List<Address>();

        /// <summary>
        /// Liste des produits appartenant au client.
        /// </summary>
        public virtual List<Product> Products { get; set; } = new List<Product>();

        /// <summary>
        /// Liste des commandes d'expédition associées au client.
        /// </summary>
        public virtual List<ShippingOrder> ShippingOrders { get; set; } = new List<ShippingOrder>();

        /// <summary>
        /// Entrepôt assigné à l'employé, qui peut être nul si aucun entrepôt n'est associé.
        /// </summary>
        public virtual Warehouse? EmployeeWarehouse { get; internal set; }


        /// <summary>
        /// Constructeur principal pour initialiser un client.
        /// </summary>
        /// <param name="clientName"> Nom de l'entreprise</param>
        /// <param name="contactFirstName">Nom de celui à contacter dans l'entrepise</param>
        /// <param name="contactLastName">prenom de celui à contacter dans l'entrepise</param>
        /// <param name="contactEmail">Boite mail de l'entreprise</param>
        /// <param name="contactTelephone">Numéro de téléphone de l'entraprise</param>
        /// <param name="warehouseId">Identifienat du fournisseur associé aux client</param>
        public Client(string clientName, string contactFirstName, string contactLastName,
            string contactEmail, string contactTelephone, int warehouseId)
        {
            this.ClientName = clientName;
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.ContactEmail = contactEmail;
            this.ContactTelephone = contactTelephone;
            this.WarehouseId = warehouseId;
        }


        /// <summary>
        /// Constructeur protégé utilisé pour des scénarios avancés (ex. : chargement depuis la base de données).
        /// </summary>
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
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
            
        }

        #region Methodes de validation et utilitaires

        /// <summary>
        /// Redéfinition de la méthode ToString pour afficher les informations d'un client
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
            return  contactTelephone.Length <= ContactEmailMaxLength; 
        }

        #endregion
    }


}
