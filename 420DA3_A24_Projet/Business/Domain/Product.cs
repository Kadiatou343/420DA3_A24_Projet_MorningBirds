using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class Product
    {
        // Constants 
        public const int PRODUCT_NAME_MAX_LENGTH = 50;
        public const int DESC_MAX_LENGTH = 256;
        public const int CODE_UPC_MAX_LENGTH = 13;
        public const int PICTURE_NAME_MAX_LENGTH = 256;
        public const int SUPPLIER_CODE_MAX_LENGTH = 128;

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Desc { get; set; }
        public string CodeUPC { get; set; }
        public String? PictureName { get; set; }
        public int ClientId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierCode { get; set; }
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



    }
}
