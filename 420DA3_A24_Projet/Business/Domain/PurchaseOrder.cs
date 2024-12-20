using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Business.Domain;

public class PurchaseOrder {
    public int Id { get; set; }
    public PurchaseOrderStatusEnum Status { get; set; }
    public int ProductId { get; set; }
    public int WarehouseId { get; set; }
    public int Quantity { get; set; }
    public DateTime? CompletionDate { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }
    public byte[] RowVersion { get; set; }
    public virtual Product OrderedProduct { get; set; }
    public virtual Warehouse Warehouse { get; set; }

    //constructeur de l'App
    public PurchaseOrder(int ProductId, int WarehouseId, int Quantity) {
       this.Status = PurchaseOrderStatusEnum.New;
        this.ProductId = ProductId;
        this.WarehouseId = WarehouseId;
        this.Quantity = Quantity;
    }
    //constructeur base de donnée
    public PurchaseOrder(int id, PurchaseOrderStatusEnum status, int productId,
        int warehouseId, int quantity, DateTime? completionDate, DateTime dateCreated, DateTime? dateDeleted
        , DateTime? dateModified, byte[] rowVersion) {
        this.Id = id;
        this.Status = status;
        this.ProductId = productId;
        this.WarehouseId = warehouseId;
        this.Quantity = quantity;
        this.CompletionDate = completionDate;
        this.DateCreated = dateCreated;
        this.DateDeleted = dateDeleted;
        this.DateModified = dateModified;
        this.RowVersion = rowVersion;
    }

    public PurchaseOrder() {
    }

    public void Complete() {

    }
}


