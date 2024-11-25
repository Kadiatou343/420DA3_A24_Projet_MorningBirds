using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Domain;

namespace ExtraAdvancedMultiTier.Business.Services;
public class AppConfigurationsService : AbstractService {
    private static AppConfigurations? configurations;

    public AppConfigurationsService(IServiceContainer parent) : base(parent) { }

    public static AppConfigurations GetConfigs() {
        configurations ??= new AppConfigurations();
        return configurations;
    }

}
