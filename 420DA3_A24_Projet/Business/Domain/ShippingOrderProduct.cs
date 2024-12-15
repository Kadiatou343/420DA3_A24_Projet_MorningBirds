namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant l'entité pivot entre ShippingOrder et Product
/// </summary>
public class ShippingOrderProduct {
    /// <summary>
    /// L'identifiant de l'ordre d'expédition associé à cette relation
    /// </summary>
    public int ShippingOrderId { get; set; }

    /// <summary>
    /// L'identifiant du produit associé à cette relation
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// La quantité du produit
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Valeur anti-concurence de EF Core
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    /// <summary>
    /// Le produit associé à cette relation
    /// </summary>
    public virtual Product Product { get; set; } = null!;

    /// <summary>
    /// L'ordre d'expédition associé à cette relation
    /// </summary>
    public virtual ShippingOrder ShippingOrder { get; set; } = null!;

    /// <summary>
    /// Constructeur par défaut
    /// </summary>
    public ShippingOrderProduct() { }

    /// <summary>
    /// Constructeur orienté création par EF Core
    /// </summary>
    /// <param name="shippingOrderId">L'identifiant de l'ordre d'expédition associé à cette relation</param>
    /// <param name="productId">L'identifiant du produit associé à cette relation</param>
    /// <param name="quantity">La quantité du produit</param>
    /// <param name="product">Le produit lui-même</param>
    /// <param name="shippingOrder">L'ordre d'expédition lui-même</param>
    /// <param name="rowVersion">Valeur anti-concurence EF Core</param>
    protected ShippingOrderProduct(int shippingOrderId, int productId,
        int quantity, Product product, ShippingOrder shippingOrder,
        byte[] rowVersion) {
        this.ShippingOrderId = shippingOrderId;
        this.ProductId = productId;
        this.Quantity = quantity;
        this.Product = product;
        this.ShippingOrder = shippingOrder;
        this.RowVersion = rowVersion;
    }
}
