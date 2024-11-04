using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class ShippingOrder
    {
        public int Id { get; set; }
        public ShippingOrderStatusEnum Status { get; set; }
        public int CreatorEmployeeId { get; set; }
        public int DestinationAdressId { get; set; }
        public int? FulfillerEmployeeId { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime DateDeleted { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Client SourceClient { get; set; }
        public User? CreatorEmployee { get; set; }
        public User? FulfillerEmployee { get; set; }
        public Address DestinationAddress { get; set; }
        public List<ShippingOrderProduct> ShippingOrderProducts { get; set;
    }
}
