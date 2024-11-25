using Exemple_Enseignant_Avance.Business.Domain;
using ExtraAdvancedMultiTier.Business.Abstractions.Daos;

namespace Exemple_Enseignant_Avance.Business.Abstractions;

/// <summary>
/// Interface représentant un DAO pour les entités de type RendezVous.
/// Utilisé comme abstraction commune pour permettre l'injection de dépendances.
/// </summary>
public interface IRendezVousDAO : IDao<RendezVous, int> {

    public List<RendezVous> Search(string criterion, bool includeDeleted = false);

    public List<RendezVous> GetByMedecin(Medecin medecin, bool includePastRdvs = false, bool includeDeleted = false);

    public List<RendezVous> GetByPatient(Patient patient, bool includePastRdvs = false, bool includeDeleted = false);

}
