using ExtraAdvancedMultiTier.Business.Domain;
using ExtraAdvancedMultiTier.Business.Services;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractApplication : AbstractFacadeContainer, IApplication {
    public readonly AppConfigurations Configurations;
    public readonly List<string> CliArguments;
    public LoggingService LoggingService { get; private set; }

    protected AbstractApplication(string[]? args = null) : base() {
        this.Configurations = AppConfigurationsService.GetConfigs();
        this.CliArguments = args?.ToList() ?? new List<string>();
        this.LoggingService = new LoggingService(this);
    }

    public AppConfigurations GetAppConfigurations() {
        return this.Configurations;
    }
}
