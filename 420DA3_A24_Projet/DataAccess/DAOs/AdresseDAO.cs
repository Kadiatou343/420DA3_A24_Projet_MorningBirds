using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class AdresseDAO {
    private readonly WsysDbContext context;

    public AdresseDAO(WsysDbContext context) {
        this.context = context;
    }
 
        public Address Create(Address address) {
            _ = this.context.Addresses.Add(address);
            _ = this.context.SaveChanges();

            return address;

        }

        public Address? GetById(int id, bool excludeDeleted = true) {
            return !excludeDeleted
                ? this.context.Addresses
                   .Where(address => address.Id == id)
                   .SingleOrDefault()
                : this.context.Addresses
                   .Where(address => address.Id == id && address.DateDeleted == null)
                   .SingleOrDefault();
        }

        public Address Update( Address address) {
            address.DateModified = DateTime.Now;
            _ = this.context.Addresses.Update(address);
            _ = this.context.SaveChanges();

            return address;
        }

  

        public List<Address> Search(string filter, bool excludeDeleted = true) {
        if (!excludeDeleted) {
                return this.context.Addresses
                   .Where(
                     client => (
                         client.AddressType.ToLower().Contains(filter.ToLower())))
                   .ToList();
        } else {

                return this.context.Addresses
                .Where(
                address=> (
                address.AddressType.ToLower().Contains(filter.ToLower())
                && address.DateDeleted == null))
                .ToList();
            }

        }
        public List<Address> GetByWarehouse (Warehouse warehouse, bool excludedDeleted = true) {

            return !excludedDeleted
                ? this.context.Addresses.Include(address => address.OwnerWarehouse)
                   .Where(
                      address => address.OwnerWarehouse != null && address.OwnerWarehouse.Equals(warehouse))
                   .ToList()
                : this.context.Addresses.Include(address => address.OwnerWarehouse)
                .Where(
                    address => address.OwnerWarehouse != null && address.OwnerWarehouse.Equals(warehouse) && address.DateDeleted == null)
                .ToList();
        }

        public List<Address> GetByShippingOrder(ShippingOrder shippingOrder, bool excludedDeleted = true) {

            return !excludedDeleted
                ? this.context.Addresses.Include(address => address.OwnerShipOrder)
                   .Where(
                      address => address.OwnerShipOrder != null && address.OwnerShipOrder.Equals(shippingOrder))
                   .ToList()
                : this.context.Addresses.Include(address => address.OwnerShipOrder)
                .Where(
                    address=> address.OwnerShipOrder!= null && address.OwnerShipOrder.Equals(shippingOrder) && address.DateDeleted == null)
                .ToList();
        }

}
