using Exemple_Enseignant_Avance.Business.Services;
using Exemple_Enseignant_Avance.Presentation;
using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Services;
using ExtraAdvancedMultiTier.Presentation;

namespace Exemple_Enseignant_Avance.Business;

/// <summary>
/// Classe représentant l'application de l'exemple avancé.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractApplication"/> pour bénéficier de la gestion des services.
/// </remarks>
internal class AdvancedExampleApplication : AbstractApplication {

    private readonly MainMenu mainMenu;

    public AdvancedExampleApplication() : base() {
        this.GetLoggingService().RegisterLogger(new DebugConsoleLogger());
        this.GetLoggingService().RegisterLogger(new ConsoleWindowLogger());
        _ = new DataProviderService(this, this.Configurations);
        this.mainMenu = new MainMenu(this);
    }

    public override void Start() {
        this.TriggerStartingEvent();
        foreach (IService service in this.Services.Values) {
            service.Start();
        }
        this.TriggerStartedEvent();
        Application.Run(this.mainMenu);
    }

    public override void Stop() {
        this.TriggerStoppingEvent();
        foreach (IService service in this.Services.Values) {
            service.Stop();
        }
        this.TriggerStoppedEvent();
    }

    public override void HandleException(Exception ex) {
        base.HandleException(ex);
        this.GetService<LoggingService>()?.Error(ex);
    }

    protected override IFacade GetAppropriateFacade() {
        throw new NotImplementedException();
    }
}
