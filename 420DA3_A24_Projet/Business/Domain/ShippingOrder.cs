using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Business.Domain;

public class ShippingOrder {
    public int Id { get; set; }
    public ShippingOrderStatusEnum Status { get; set; }

    public int SourceClientId { get; set; }

    public int? ShipmentId { get; set; }
    public int CreatorEmployeeId { get; set; }
    public int DestinationAdressId { get; set; }
    public int? FulfillerEmployeeId { get; set; }
    public DateTime? ShippingDate { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }
    public byte[] RowVersion { get; set; }


    public virtual Client SourceClient { get; set; }
    public virtual User CreatorEmployee { get; set; }
    public virtual Shipment? Shipment { get; set; }
    public virtual User? FulfillerEmployee { get; set; }
    public virtual Address DestinationAddress { get; set; }
    public virtual List<ShippingOrderProduct> ShippingOrderProducts { get; set; }



    //constructeur de l'App
    public ShippingOrder(int CreatorEmployeeId, int DestinationAdressId) {
        this.CreatorEmployeeId = CreatorEmployeeId;
        this.DestinationAdressId = DestinationAdressId;
    }
    //constructeur base de donnée

    protected ShippingOrder(int id, ShippingOrderStatusEnum status, int? shipmentId, int creatorEmployeeId, 
        int sourceClientId, int destinationAdressId,
        int fulfillerEmployeeId, DateTime? shippingDate, DateTime dateCreated, DateTime? dateDeleted,
         DateTime? dateModified, byte[] rowVersion) {
        this.Id = id;
        this.Status = ShippingOrderStatusEnum.New;
        this.SourceClientId = sourceClientId;
        this.CreatorEmployeeId = creatorEmployeeId;
        this.DestinationAdressId = destinationAdressId;
        this.FulfillerEmployeeId = fulfillerEmployeeId;
        this.ShippingDate = shippingDate;
        this.DateDeleted = dateDeleted;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.RowVersion = rowVersion;
    }

    public ShippingOrder() {
        this.Status = ShippingOrderStatusEnum.New;
    }
    public ShippingOrder(int id, int sourceClientId,int shipmentId, int creatorEmployeeId, int destinationAdressId, int? fulfillerEmployeeId) { 
        this.Id= id;
        this.Status = ShippingOrderStatusEnum.New;
        this.SourceClientId = sourceClientId;
        this.ShipmentId = shipmentId;
        this.CreatorEmployeeId = creatorEmployeeId;
        this.DestinationAdressId = destinationAdressId;
        this.FulfillerEmployeeId = fulfillerEmployeeId;
  
    }
}
