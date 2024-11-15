using Exemple_Enseignant_Avance.Business.Services;
using ExtraAdvancedMultiTier.Business.Abstractions;

namespace Exemple_Enseignant_Avance.Business.Facades;
internal class GeneralFacade : AbstractFacade {
    public GeneralFacade(IFacadeContainer parent, DataProviderService dataProviderService) : base(parent) {
        _ = new PatientService(this);
    }

}
