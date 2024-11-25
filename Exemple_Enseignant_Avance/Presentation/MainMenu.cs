using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Services;

namespace Exemple_Enseignant_Avance.Presentation;
public partial class MainMenu : Form {
    private IServiceContainer ServiceContainer { get; set; }
    public MainMenu(IServiceContainer parent) {
        this.ServiceContainer = parent;
        this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        this.ServiceContainer.GetService<LoggingService>().Debug("Test");
        this.ServiceContainer.GetService<LoggingService>().Info("Test");
        this.ServiceContainer.GetService<LoggingService>().Success("Test");
        this.ServiceContainer.GetService<LoggingService>().Warn("Test");
        this.ServiceContainer.GetService<LoggingService>().Error("Test");
        this.ServiceContainer.GetService<LoggingService>().Critical("Test");
    }

    private void MainMenu_FormClosing(object sender, FormClosingEventArgs e) {
        this.ServiceContainer.Stop();
    }
}
