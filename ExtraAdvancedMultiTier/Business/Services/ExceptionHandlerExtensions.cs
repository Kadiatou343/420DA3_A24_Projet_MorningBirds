using ExtraAdvancedMultiTier.Business.Abstractions;
using System.Text;

namespace ExtraAdvancedMultiTier.Business.Services;
public static class ExceptionHandlerExtensions {

    public static void HandleException(this IExceptionHandler handler, Exception ex) {
        string? stack = ex.StackTrace;
        StringBuilder messageBuilder = new StringBuilder();
        Console.Error.WriteLine(ex.Message);
        _ = messageBuilder.Append(ex.Message);
        while (ex.InnerException != null) {
            ex = ex.InnerException;
            Console.Error.WriteLine(ex.Message);
            _ = messageBuilder.Append(Environment.NewLine + "Caused By: " + ex.Message);
        }
        Console.Error.WriteLine("Stack trace:");
        Console.Error.WriteLine(stack);
        _ = MessageBox.Show(messageBuilder.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }

}
