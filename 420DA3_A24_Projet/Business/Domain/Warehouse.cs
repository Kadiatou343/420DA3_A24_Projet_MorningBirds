using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class Warehouse
    {
        public const int WAREHOUSE_NAME_MAX_LENGTH = 128;

        //Attributs
        
        public int Id { get; set; }
        public string WareHouseName { get; set; }
        public int AddressId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDeleted { get; set; }
        public DateTime? DateModified { get; set; }

        public byte[] RowVersion { get; set; } = null!;

        //public List<Client> Clients { get; set; } = new List<Client>();
        //public Addresse Adresse { get; set; }
        //public List<PurchaseOrder> RestockOrders { get; set; } = new List<PurchaseOrder>();
        public List<User> WarehouseEmployees { get; set; } = new List<User>();

        //Constructeur création

        public Warehouse(string wareHouseName, int adressId) 
        {
            this.WareHouseName = wareHouseName;
            this.AddressId = adressId;
        }

        //Constructeur pour le Data base

        //Methodes de validation

        public bool ValidateWarehouseName(string warehouseName)
        {
            return warehouseName.Length <= WAREHOUSE_NAME_MAX_LENGTH;
        }

    }
}
