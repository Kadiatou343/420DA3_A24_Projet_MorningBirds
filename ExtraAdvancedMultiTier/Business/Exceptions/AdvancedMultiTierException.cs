using ExtraAdvancedMultiTier.Business.Abstractions;

namespace ExtraAdvancedMultiTier.Business.Exceptions;
public class AdvancedMultiTierException : AbstractException<string> {

    public AdvancedMultiTierException(string? message = null, string? code = null, Exception? previous = null) : base(message, code, previous) { }
}
