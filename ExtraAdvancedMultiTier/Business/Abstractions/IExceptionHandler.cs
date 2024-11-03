namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IExceptionHandler {

    public delegate void ExceptionThrownEvent(Exception ex);

    public event ExceptionThrownEvent ExceptionThrown;

    public void TriggerExceptionThrownEvent(Exception ex);

    public void HandleException(Exception ex);

}
