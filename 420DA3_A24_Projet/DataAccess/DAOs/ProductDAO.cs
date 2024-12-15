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

    /// <summary>
    /// Constructor of the class
    /// </summary>
    /// <param name="context">The context that need to be passed</param>
    public ProductDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Create a new Product 
    /// </summary>
    /// <param name="product">The product to add</param>
    /// <returns>the product added</returns>
    public Product Create(Product product) {
        _ = this.context.Products.Add(product);
        _ = this.context.SaveChanges();

        return product;
    }

    /// <summary>
    /// Update an existing product 
    /// </summary>
    /// <param name="product">the product to update</param>
    /// <returns>the updated product</returns>
    public Product Update(Product product) {
        product.DateModified = DateTime.Now;
        _ = this.context.Products.Update(product);
        _ = this.context.SaveChanges();

        return product;
    }

    /// <summary>
    /// Delete an existing product
    /// </summary>
    /// <param name="product">the product to delete</param>
    /// <param name="softDelete">do we soft delete ?</param>
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

    /// <summary>
    /// Obtenir tout les product existants
    /// </summary>
    /// <param name="excludeDeleted">on exlus les product deleted ?</param>
    /// <returns>list des product</returns>
    public List<Product> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Products.ToList()
            : this.context.Products.Where(product => product.DateDeleted == null).ToList();
    }

    /// <summary>
    /// Obtenir un product par son ID
    /// </summary>
    /// <param name="id">le id du product</param>
    /// <param name="excludeDeleted">on exlus les product deleted ?</param>
    /// <returns>the product found</returns>
    public Product? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Products
                .Where(product => product.ProductId == id)
                .SingleOrDefault()
            : this.context.Products
                .Where(product => product.ProductId == id && product.DateDeleted == null)
                .SingleOrDefault();
    }

    /// <summary>
    /// Search a product by either its name, contact firstname or constact lastname
    /// </summary>
    /// <param name="filter">the search element</param>
    /// <param name="excludeDeleted">on exlus les product deleted ?</param>
    /// <returns>a list of product based on the filter</returns>
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
