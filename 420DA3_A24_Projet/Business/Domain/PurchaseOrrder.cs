using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    internal class PurchaseOrrder
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
        public Product OrderedProduct { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
