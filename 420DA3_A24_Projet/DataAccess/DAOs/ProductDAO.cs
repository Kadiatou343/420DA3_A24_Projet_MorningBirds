using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ProductDAO {
    private readonly WsysDbContext context;

    public ProductDAO(WsysDbContext context) {
        this.context = context;
    }

    public Product Create(Product product) {
        _ = this.context.Products.Add(product);
        _ = this.context.SaveChanges();

        return product;
    }

    public Product Update(Product product) {
        product.DateModified = DateTime.Now;
        _ = this.context.Products.Update(product);
        _ = this.context.SaveChanges();

        return product;
    }

    public void Delete(Product product, bool softDeleted = true) {
        if (softDeleted) {
            product.DateDeleted = DateTime.Now;
            _ = this.context.Products.Update(product);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.Products.Remove(product);
            _ = this.context.SaveChanges();
        }
    }

    public List<Product> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Products.ToList()
            : this.context.Products.Where(product => product.DateDeleted == null).ToList();
    }

    public Product? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Products
                .Where(product => product.ProductId == id)
                .SingleOrDefault()
            : this.context.Products
                .Where(product => product.ProductId == id && product.DateDeleted == null)
                .SingleOrDefault();
    }

    public List<Product> Search(string filter, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Products
                .Where(
                    product => (
                         product.ProductName.ToLower().Contains(filter.ToLower())
                         || product.Desc.ToLower().Contains(filter.ToLower())))
                .ToList()
            : this.context.Products
                .Where(
                    product => (
                         product.ProductName.ToLower().Contains(filter.ToLower())
                         || product.Desc.ToLower().Contains(filter.ToLower()))
                         && product.DateDeleted == null)
                .ToList();
    }
}
