using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
/// <summary>
/// Classe représentant la classe d'accès aux données d'un Shipment
/// </summary>
internal class ShipmentDAO {

    /// <summary>
    /// Le contexte utilisé par le DAO
    /// </summary>
    private readonly WsysDbContext context;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="context">Contexte de l'app</param>
    public ShipmentDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Créer un shipment
    /// </summary>
    /// <param name="shipment">Shipment à créer</param>
    /// <returns>Le shipment créé</returns>
    public Shipment Create(Shipment shipment) {
        _ = this.context.Shipments.Add(shipment);
        _ = this.context.SaveChanges();

        return shipment;
    }

    /// <summary>
    /// Modification shipment
    /// </summary>
    /// <param name="shipment">Shiment à modifier</param>
    /// <returns>Le shipment mis à jour</returns>
    public Shipment Update(Shipment shipment) {
        shipment.DateModified = DateTime.Now;
        _ = this.context.Shipments.Update(shipment);
        _ = this.context.SaveChanges();

        return shipment;
    }


    /// <summary>
    /// Supprimer un shipment
    /// </summary>
    /// <param name="shipment">Shipment à supprimer</param>
    /// <param name="softDelete">Detail de supprimer durement ou de marquer supprimé</param>
    public void Delete(Shipment shipment, bool softDelete = true) {
        if (softDelete) {
            shipment.DateDeleted = DateTime.Now;
            _ = this.context.Update(shipment);
            _ = this.context.SaveChanges();
        } else {
            _ = this.context.Remove(shipment);
            _ = this.context.SaveChanges();
        }
    }

    /// <summary>
    ///  Obtenir un shipment par son Id
    /// </summary>
    /// <param name="id">Id du shipment à chercher</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Le warehouse avec cet id</returns>
    public Shipment? GetById(int id, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Shipments
                .Where(shipment => shipment.Id == id)
                .SingleOrDefault()
            : this.context.Shipments
                .Where(shipment => shipment.Id == id && excludeDeleted == null)
                .SingleOrDefault();
    }

    /// <summary>
    /// Obtenir les shipments par un filtre
    /// </summary>
    /// <param name="filter">Condition de recherche</param>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste de shipment</returns>
    public List<Shipment> Search(string filter, bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Shipments
                .Where(shipment =>
                    shipment.TrackingNumber.ToLower().Contains(filter.ToLower()))
                .ToList()
            : this.context.Shipments
                .Where(shipment =>
                    shipment.TrackingNumber.ToLower().Contains(filter.ToLower())
                    && shipment.DateDeleted == null)
                .ToList();
    }

    /// <summary>
    /// Obtenir touts les shipments
    /// </summary>
    /// <param name="excludeDeleted">Detail d'exclure les utilisateurs marqués supprimés ou non</param>
    /// <returns>Liste de shipment</returns>
    public List<Shipment> GetAll(bool excludeDeleted = true) {
        return !excludeDeleted
            ? this.context.Shipments.ToList()
            : this.context.Shipments
                .Where(shipment => shipment.DateDeleted == null)
                .ToList();
    }
}
