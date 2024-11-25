using ExtraAdvancedMultiTier.Business.Services;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface ILoggingServiceContainer {

    public LoggingService GetLoggingService();

}
