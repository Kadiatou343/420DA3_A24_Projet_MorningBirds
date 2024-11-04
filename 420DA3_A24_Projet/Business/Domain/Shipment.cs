using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class Shipment
    {
        public const int TRACKING_NUMBER_MAX_LENGTH = 32;

        //Attributs

        public int Id { get; set; }
        public ShipmentStatusEnum Status { get; set; }
        public ShippingProvidersEnum ShippingService { get; set; }
        public int ShippingOrderId { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDeleted { get; set; }
        public DateTime? DateModified { get; set;}
        public byte[] RowVersion { get; set; } = null!; 
        //public ShippingOrder ShippingOrder { get; set; }

        //Constructeur création

        public Shipment(int shippingOrderId, string trackingNumber)
        {
            this.ShippingOrderId = shippingOrderId;
            this.TrackingNumber = trackingNumber;
        }

        //Constructeur pour la data base


        //Methode de validation
        public bool ValidateTrackingNumber(string trackingNumber)
        {
            return trackingNumber.Length <= TRACKING_NUMBER_MAX_LENGTH;
        }
    }
}
