using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public PurchaseOrderStatusEnum Status { get; set; }
        public int ProductId  { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime? DateDeleted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public virtual Product OrderedProduct { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        //constructeur de l'App
        public PurchaseOrder(int ProductId, int WarehouseId,int Quantity) {
            this.ProductId = ProductId;
            this.WarehouseId = WarehouseId;
            this.Quantity = Quantity;
        }
        //constructeur base de donnée
        public PurchaseOrder(int id,PurchaseOrderStatusEnum status, int productId, 
            int warehouseId, int quantity, DateTime completionDate, DateTime? dateDeleted,
            DateTime? dateCreated, DateTime? dateModified, Product orderedProduct, Warehouse warehouse) {
            this.Id = id;
            this.Status = status;
            this.ProductId = productId;
            this.WarehouseId = warehouseId;
            this.Quantity = quantity;
            this.CompletionDate = completionDate;
            this.DateDeleted = dateDeleted;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.OrderedProduct = orderedProduct;
            this.Warehouse = warehouse;
        }

        public void Complete() {

        }
    }

    
}
