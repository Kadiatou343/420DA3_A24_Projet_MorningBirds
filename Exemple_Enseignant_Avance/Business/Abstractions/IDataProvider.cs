using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.Business.Abstractions;

/// <summary>
/// Interface représentant un fournisseur de données (fournisseur de classes DAO).
/// Utilisé comme abstraction commune pour permettre l'injection de dépendances.
/// </summary>
public interface IDataProvider {

    public IPatientDAO GetPatientDao();

    public IMedecinDAO GetMedecinDao();

    public IRendezVousDAO GetRendezVousDao();

}
