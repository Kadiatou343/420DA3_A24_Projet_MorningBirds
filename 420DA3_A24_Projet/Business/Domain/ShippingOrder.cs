using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Business.Domain;

public class ShippingOrder {
    public int Id { get; set; }
    public ShippingOrderStatusEnum Status { get; set; }

    public int SourceClientId { get; set; }

    public int shipmentId { get; set; }
    public int CreatorEmployeeId { get; set; }
    public int DestinationAdressId { get; set; }
    public int? FulfillerEmployeeId { get; set; }
    public DateTime? ShippingDate { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }
    public virtual Client SourceClient { get; set; }
    public virtual Shipment Shipment { get; set; }
    public virtual User? CreatorEmployee { get; set; }
    public virtual User? FulfillerEmployee { get; set; }
    public virtual Address DestinationAddress { get; set; }
    public virtual List<ShippingOrderProduct> ShippingOrderProducts { get; set; }



    //constructeur de l'App
    public ShippingOrder(int CreatorEmployeeId, int DestinationAdressId) {
        this.CreatorEmployeeId = CreatorEmployeeId;
        this.DestinationAdressId = DestinationAdressId;
    }
    //constructeur base de donnée

    public ShippingOrder(int id, int CreatorEmployeeId, int SourceClientId, int DestinationAdressId,
        int FulfillerEmployeeId, DateTime ShippingDate, DateTime DateCreated, DateTime DateDeleted,
         DateTime DateModified, Client SourceClient, User CreatorEmployee,
        User FulfillerEmployee, Address DestinationAddress) {
        this.Id = id;
        this.SourceClient = SourceClient;
        this.CreatorEmployeeId = CreatorEmployeeId;
        this.DestinationAdressId = DestinationAdressId;
        this.FulfillerEmployeeId = FulfillerEmployeeId;
        this.ShippingDate = ShippingDate;
        this.DateDeleted = DateDeleted;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.SourceClient = SourceClient;
        this.CreatorEmployee = CreatorEmployee;
        this.FulfillerEmployee = FulfillerEmployee;
        this.DestinationAddress = DestinationAddress;
    }

    public ShippingOrder() {
    }
    public ShippingOrder(int id, int sourceClientId,int shipmentId, int creatorEmployeeId, int destinationAdressId, int? fulfillerEmployeeId) { 
        this.Id= id;
        this.SourceClientId = sourceClientId;
        this.shipmentId = shipmentId;
        this.CreatorEmployeeId = creatorEmployeeId;
        this.DestinationAdressId = destinationAdressId;
        this.FulfillerEmployeeId = fulfillerEmployeeId;
  
    }
}
