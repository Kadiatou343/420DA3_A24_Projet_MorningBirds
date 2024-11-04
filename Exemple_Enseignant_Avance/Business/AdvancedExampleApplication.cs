using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Services;
using Exemple_Enseignant_Avance.DataAccess;
using ExtraAdvancedMultiTier.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.Business;
internal class AdvancedExampleApplication : AbstractApplication {

    public AdvancedExampleApplication() {
        _ = new DataProviderService(this, this.Configurations);
        _ = new PatientService(this);
    }

    public override void Start() {
        this.TriggerStartingEvent();
        foreach (IService service in this.Services.Values) {
            service.Start();
        }
        this.TriggerStartedEvent();
    }

}
