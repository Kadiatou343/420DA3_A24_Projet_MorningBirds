namespace Project_Utilities.Exceptions;
public class NotOverriddenException : Exception {

    public NotOverriddenException(string? message = null, Exception? innerException = null)
        : base(message, innerException) { }

}
