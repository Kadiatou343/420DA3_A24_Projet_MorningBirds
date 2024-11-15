using Project_Utilities.Enums;
using Project_Utilities.Services.Abstracts;
using System.Text;

namespace ExtraAdvancedMultiTier.Business.Services;
public class DebugConsoleLogger : ILogger {
    public LoggingLevelsEnum LogLevel { get; private set; } = LoggingLevelsEnum.DEBUG;

    public void Start() { }

    public void SetLoggingLevel(LoggingLevelsEnum level) {
        this.LogLevel = level;
    }

    public void Critical(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.CRITICAL) {
            System.Diagnostics.Debug.WriteLine($"[CRITICAL] {this.ConvertObjectToString(obj)}");
        }
    }

    public void Error(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.ERROR) {
            System.Diagnostics.Debug.WriteLine($"[ERROR] {this.ConvertObjectToString(obj)}");
        }
    }

    public void Warn(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.WARNING) {
            System.Diagnostics.Debug.WriteLine($"[WARNING] {this.ConvertObjectToString(obj)}");
        }
    }

    public void Success(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.SUCCESS) {
            System.Diagnostics.Debug.WriteLine($"[SUCCESS] {this.ConvertObjectToString(obj)}");
        }
    }

    public void Info(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.INFO) {
            System.Diagnostics.Debug.WriteLine($"[INFO] {this.ConvertObjectToString(obj)}");
        }
    }

    public void Debug(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.DEBUG) {
            System.Diagnostics.Debug.WriteLine($"[DEBUG] {this.ConvertObjectToString(obj)}");
        }
    }

    private string ConvertObjectToString(object obj) {
        string? text;
        if (obj is Exception ex) {
            StringBuilder sb = new StringBuilder();
            _ = sb.AppendLine($"Exception: {ex.Message}");
            Exception? previous = ex.InnerException;
            while (previous != null) {
                _ = sb.AppendLine($"Caused By: {previous.Message}");
                previous = previous.InnerException;
            }
            _ = sb.AppendLine($"Stack Trace: {ex.StackTrace}");
            text = sb.ToString();
        } else {
            text = obj.ToString();
        }
        return text ?? "<null>";
    }
}
