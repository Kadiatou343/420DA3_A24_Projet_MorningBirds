using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Class représentant le service d'un product
/// </summary>
internal class ProductService {
    /// <summary>
    /// le dao du product
    /// </summary>
    private readonly ProductDAO dao;
    /// <summary>
    /// la view associer a ce service
    /// </summary>
    private readonly ProductView view;

    /// <summary>
    /// Constructeur du service de product
    /// </summary>
    /// <param name="parentApp">L'application parent</param>
    /// <param name="context">Le context de l'application</param>
    public ProductService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new ProductDAO(context);
        this.view = new ProductView(parentApp);
    }

    /// <summary>
    /// From a search element return a list of product
    /// </summary>
    /// <param name="searchElement">the search element</param>
    /// <param name="excludeDeleted">exclude deleted supplier ?</param>
    /// <returns>A list of product</returns>
    public List<Product> SearchProduct(string searchElement, bool excludeDeleted = true) {
        return this.dao.Search(searchElement, excludeDeleted);
    }

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product">the product that will be created</param>
    /// <returns>the product created</returns>
    public Product CreateProduct(Product product) {
        return this.dao.Create(product);
    }

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product">the product to update</param>
    /// <returns>the updated product</returns>
    public Product UpdateProduct(Product product) {
        return this.dao.Update(product);
    }

    /// <summary>
    /// Delete an existing product
    /// </summary>
    /// <param name="product">the product to delete</param>
    /// <param name="softDelete">do we soft delete ?</param>
    public void DeleteProduct(Product product, bool softDelete = true) {
        this.dao.Delete(product, softDelete);
    }

    /// <summary>
    /// Obtenir tout les produits
    /// </summary>
    /// <param name="excludeDeleted">exclus les product deleted ?</param>
    /// <returns>liste de tout les produits</returns>
    public List<Product> GetAllProducts(bool excludeDeleted = true) {
        return this.dao.GetAll(excludeDeleted);
    }

    /// <summary>
    /// Obtenir un produit spécifique en fonction de son id 
    /// </summary>
    /// <param name="id">le id du produit</param>
    /// <param name="excludeDeleted">on exclus les product deleted ?</param>
    /// <returns>the product object</returns>
    public Product? GetProductById(int id, bool excludeDeleted = true) {
        return this.dao.GetById(id, excludeDeleted);
    }

    // fonctions pour ouvrir les fenêtres

    /// <summary>
    /// Ouvre la vue pour la création d'un nouveau produit
    /// </summary>
    /// <returns>La vue ou null</returns>
    public Product? OpenViewForCreation() {
        Product product = new Product();
        DialogResult result = this.view.OpenForCreation(product);
        return result == DialogResult.OK ? product : null;
    }

    /// <summary>
    /// Ouvre la vue pour voir un produit
    /// </summary>
    /// <param name="product">le produit à voir</param>
    /// <returns>le produit</returns>
    public Product OpenViewForView(Product product) {
        _ = this.view.OpenForView(product);
        return product;
    }

    /// <summary>
    /// Ouvre la vue pour modifier un produit
    /// </summary>
    /// <param name="product">le produit à modifier</param>
    /// <returns>la vue ou null</returns>
    public Product? OpenViewForModification(Product product) {
        DialogResult result = this.view.OpenForModification(product);
        return result == DialogResult.OK ? product : null;
    }

    /// <summary>
    /// ouvre la vue pour supprimer un produit
    /// </summary>
    /// <param name="product">Le produit a supprimer</param>
    /// <returns>la vue ou null</returns>
    public Product? OpenViewForDeletion(Product product) {
        DialogResult result = this.view.OpenForDeletion(product);
        return result == DialogResult.OK ? product : null;
    }
}
