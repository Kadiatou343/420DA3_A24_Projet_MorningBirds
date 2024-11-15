using Exemple_Enseignant_Avance.Business.Domain;
using ExtraAdvancedMultiTier.Business.Abstractions.Daos;

namespace Exemple_Enseignant_Avance.Business.Abstractions;

/// <summary>
/// Interface représentant un DAO pour les entités de type Medecin.
/// Utilisé comme abstraction commune pour permettre l'injection de dépendances.
/// </summary>
public interface IMedecinDAO : IDao<Medecin, int> {


    public List<Medecin> Search(string criterion, bool withRendezVous = false, bool includeDeleted = false);

}
