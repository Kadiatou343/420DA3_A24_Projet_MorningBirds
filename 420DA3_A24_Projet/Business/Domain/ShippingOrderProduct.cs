using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class ShippingOrderProduct {
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public virtual Product Product { get; set; }
     public ShippingOrder ShippingOrder { get; set; }

    public ShippingOrderProduct() { 
    }

    public ShippingOrderProduct(int id, int productId, int quantity, Product product, ShippingOrder shippingOrder) {
        this.Id = id;
        this.ProductId = productId;
        this.Quantity = quantity;
        this.Product = product;
        this.ShippingOrder = shippingOrder;
    }
}
