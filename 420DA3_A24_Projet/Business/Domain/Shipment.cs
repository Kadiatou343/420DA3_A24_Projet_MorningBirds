using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Business.Domain;


/// <summary>
/// Classe représentant une expedition.
/// </summary>
public class Shipment {
    /// <summary>
    /// Longeur maximale de numéro d'expédition.
    /// </summary>
    public const int TRACKING_NUMBER_MAX_LENGTH = 32;
    private readonly string trackingnumber = null!;

    //Attributs

    public int Id { get; set; }

    //Donnés de l'expédition
    public ShipmentStatusEnum Status { get; set; }
    public ShippingProvidersEnum ShippingService { get; set; }
    public int ShippingOrderId { get; set; }
    public string TrackingNumber {
        get { return this.trackingnumber; }
        set {
            if (!this.ValidateTrackingNumber(value)) {
                throw new ArgumentOutOfRangeException("TrackingNumber", $"La longueur de Tracking Number devrait être inférieur à {TRACKING_NUMBER_MAX_LENGTH}!");
            }
        }
    }

    // Meta-donnees 
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    // Propriétés de navigation EF Core

    /// <summary>
    /// L'orde d'expedition associé à cet expédition
    /// </summary>
    public virtual ShippingOrder ShippingOrder { get; set; }

    /// <summary>
    /// Constructeur orienté création manuelle
    /// </summary>
    /// <param name="shippingOrderId">Identificant de l'ordre d'expédition associé à cet expédition</param>
    /// <param name="status">L'état de l'expédition (New, PickedUp, Delivered)</param>
    /// <param name="shippingService">Le service d'expédition (Fedex, Purolator, CanadaPost)</param>
    /// <param name="trackingNumber">Code de suivi généré automatiquement par le service de livraison</param>

    public Shipment(ShipmentStatusEnum status, ShippingProvidersEnum shippingService, int shippingOrderId, string trackingNumber) {
        this.ShippingOrderId = shippingOrderId;
        this.Status = status;
        this.ShippingService = shippingService;
        this.TrackingNumber = trackingNumber;
    }

    /// <summary>
    /// Constructeur orienté création par Entity Framework 
    /// </summary>
    /// <param name="id">Identificant de l'expédition</param>
    /// <param name="status">État de l'expédition</param>
    /// <param name="shippingService">Service associé à cet expédition</param>
    /// <param name="shippingOrderId">L'identificant de L'ordre d'expédition associé à cette expédition</param>
    /// <param name="trackingNumber">Le code de suivi</param>
    /// <param name="dateCreated">Date de création de l'expédition dans la BD</param>
    /// <param name="dateDeleted">Date de suppresion de l'expédition dans la BD</param>
    /// <param name="dateModified">Date de modification de l'expédition dans la BD</param>
    /// <param name="rowVersion">Valeur anti-concurrence de la base de données</param>

    protected Shipment(
        int id,
        ShipmentStatusEnum status,
        ShippingProvidersEnum shippingService,
        int shippingOrderId,
        string trackingNumber,
        DateTime dateCreated,
        DateTime? dateDeleted,
        DateTime? dateModified,
        byte[] rowVersion) : this(status, shippingService, shippingOrderId, trackingNumber) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateDeleted = dateDeleted;
        this.DateModified = dateModified;
        this.RowVersion = rowVersion;
    }

    #region Methodes

    //Methode de validation longeur code de suivi
    public bool ValidateTrackingNumber(string trackingNumber) {
        return trackingNumber.Length <= TRACKING_NUMBER_MAX_LENGTH;
    }

    #endregion
}
