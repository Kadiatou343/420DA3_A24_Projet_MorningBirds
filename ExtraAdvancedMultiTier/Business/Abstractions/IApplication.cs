using ExtraAdvancedMultiTier.Business.Domain;

namespace ExtraAdvancedMultiTier.Business.Abstractions;

public interface IApplication : IStartable, IStoppable {

    public AppConfigurations GetAppConfigurations();

}
