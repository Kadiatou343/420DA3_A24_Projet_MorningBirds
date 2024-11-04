using Exemple_Enseignant_Avance.Business.Domain;
using ExtraAdvancedMultiTier.Business.Abstractions.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.Business.Abstractions;
public interface IRendezVousDAO : IDao<RendezVous, int> {

    public List<RendezVous> Search(string criterion, bool includeDeleted = false);

    public List<RendezVous> GetByMedecin(Medecin medecin, bool includePastRdvs = false, bool includeDeleted = false);

    public List<RendezVous> GetByPatient(Patient patient, bool includePastRdvs = false, bool includeDeleted = false);

}
