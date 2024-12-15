using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    /// <summary>
    /// Class représentant un Product
    /// </summary>
    public class Product
    {
        // Constants 
        /// <summary>
        /// Longueur Maximale du Product Name
        /// </summary>
        public const int PRODUCT_NAME_MAX_LENGTH = 50;
        /// <summary>
        /// Longueur Maximale de la description du produit
        /// </summary>
        public const int DESC_MAX_LENGTH = 256;
        /// <summary>
        /// Longueur Maximale du code UPC du produit
        /// </summary>
        public const int CODE_UPC_MAX_LENGTH = 12;
        /// <summary>
        /// Longueur Maximale du Picture Name du produit
        /// </summary>
        public const int PICTURE_NAME_MAX_LENGTH = 256;
        /// <summary>
        /// Longueur Maximale du supplier code du produit
        /// </summary>
        public const int SUPPLIER_CODE_MAX_LENGTH = 128;

        // Private properties 

        /// <summary>
        /// Champ privé pour le product name
        /// </summary>
        private string productName = null!;
        /// <summary>
        /// Champ privé pour la description du produit
        /// </summary>
        private string desc = null!;
        /// <summary>
        /// Champ privé pour le code UPC du produit
        /// </summary>
        private string codeUPC = null!;
        /// <summary>
        /// Champ privé pour le picture name du produit
        /// </summary>
        private string pictureName = null!;
        /// <summary>
        /// Champ privé pour le code du supplier
        /// </summary>
        private string supplierCode = null!;

        /// <summary>
        /// Le id du product
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Le nom du produit
        /// </summary>
        public string ProductName { get {
                return this.productName;
            } set {
                this.productName = !ValidateProductName(value)
                    ? throw new ArgumentOutOfRangeException($"Product Name must be under {PRODUCT_NAME_MAX_LENGTH} character!")
                    : value;
            } }
        
        /// <summary>
        /// La description du produit
        /// </summary>
        public string Desc { get {
                return this.desc;
            } set {
                this.desc = !ValidateProductDesc(value)
                    ? throw new ArgumentOutOfRangeException($"Product Desc must be under {DESC_MAX_LENGTH} characters!")
                    : value;
            } }
        
        /// <summary>
        /// le code UPC du produit
        /// </summary>
        public string CodeUPC { get {
                return this.codeUPC;
            } set {
                this.codeUPC = !ValidateCodeUPC(value)
                    ? throw new ArgumentOutOfRangeException($"Product Code UPC must be exactly {CODE_UPC_MAX_LENGTH} characters!")
                    : value;
            } }
        
        /// <summary>
        /// Picture name du produit
        /// </summary>
        public String? PictureName { get {
                return this.pictureName;
            } set {
                this.pictureName = !ValidatePictureName(value)
                    ? throw new ArgumentOutOfRangeException($"Product Picture Name must be under {PICTURE_NAME_MAX_LENGTH} characters!")
                    : value;
            } }
        
        /// <summary>
        /// Le id du client
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Le id du supplier 
        /// </summary>
        public int SupplierId { get; set; }
        public string SupplierCode { get {
                return this.supplierCode;
            } set {
                this.supplierCode = !ValidateSupplierCode(value)
                    ? throw new ArgumentOutOfRangeException($"Product Supplier Code must be under {SUPPLIER_CODE_MAX_LENGTH} characters!")
                    : value;
            } }
        public int Quantity { get; set; }
        public int AimQuantity { get; set; }
        public double Weight { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; } = null!;

        // Propriété de navigation 
        public virtual Supplier Supplier { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;

        public virtual List<PurchaseOrder> PurchaseOrders { get; set; } = null!;
        public virtual List<ShippingOrderProduct> ShippingOrderProducts { get; set; } = null!;

        // Constructeur
        public Product(string productName, string desc, string codeUPC, int clientId, int supplierId, string supplierCode, int quantity,
            int aimQuantity, double weight, string? pictureName = null)
        { 
            this.ProductName = productName;
            this.Desc = desc;  
            this.CodeUPC = codeUPC;
            this.ClientId = clientId;
            this.SupplierId = supplierId;
            this.SupplierCode = supplierCode;
            this.Quantity = quantity;
            this.AimQuantity = aimQuantity;
            this.Weight = weight;
            this.PictureName = pictureName;
        }

        // Constructeur de BD 
        private Product(int productId, string productName, string desc, string codeUPC, int clientId, int supplierId, string supplierCode, int quantity,
            int aimQuantity, double weight, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion, string? pictureName = null)
            : this(productName, desc, codeUPC, clientId, supplierId, supplierCode, quantity, aimQuantity, weight, pictureName)
        { 
            this.ProductId = productId;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;
        }

        // Constructeur vide
        public Product() { }

        #region METHODES DE VERIFICATION
        static private bool ValidateProductName(string value) {
            return value.Length <= PRODUCT_NAME_MAX_LENGTH;
        }

        static private bool ValidateProductDesc(string value) {
            return value.Length <= DESC_MAX_LENGTH;
        }

        static private bool ValidateCodeUPC(string value) {
            return value.Length == CODE_UPC_MAX_LENGTH;
        }

        static private bool ValidatePictureName(string value) {
            return value.Length <= PICTURE_NAME_MAX_LENGTH || value == null;
        }

        static private bool ValidateSupplierCode(string value) {
            return value.Length <= SUPPLIER_CODE_MAX_LENGTH;
        }

        #endregion

        #region METHODES
        
        public override string ToString() {
            return $"#{this.ProductId} - {this.productName} | {this.Quantity}"; 
        }
        #endregion

    }
}
