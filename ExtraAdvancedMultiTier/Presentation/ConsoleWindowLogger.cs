using Project_Utilities.Enums;
using Project_Utilities.Services.Abstracts;
using System.Text;

namespace ExtraAdvancedMultiTier.Presentation;
public partial class ConsoleWindowLogger : Form, ILogger {
    public LoggingLevelsEnum LogLevel { get; private set; } = LoggingLevelsEnum.DEBUG;

    public ConsoleWindowLogger() {
        this.InitializeComponent();
    }

    public void Start() {
        this.Show();
    }

    public void SetLoggingLevel(LoggingLevelsEnum level) {
        this.LogLevel = level;
    }

    public void Critical(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.CRITICAL) {
            this.AppendText($"[CRITICAL] {this.ConvertObjectToString(obj)}", Color.Red, true);
        }
    }

    public void Error(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.ERROR) {
            this.AppendText($"[ERROR] {this.ConvertObjectToString(obj)}", Color.Red, true);
        }
    }

    public void Warn(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.WARNING) {
            this.AppendText($"[WARNING] {this.ConvertObjectToString(obj)}", Color.Goldenrod, true);
        }
    }

    public void Success(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.SUCCESS) {
            this.AppendText($"[SUCCESS] {this.ConvertObjectToString(obj)}", Color.LimeGreen, true);
        }
    }

    public void Info(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.INFO) {
            this.AppendText($"[INFO] {this.ConvertObjectToString(obj)}", Color.DodgerBlue, true);
        }
    }

    public void Debug(object obj) {
        if (this.LogLevel <= LoggingLevelsEnum.DEBUG) {
            this.AppendText($"[DEBUG] {this.ConvertObjectToString(obj)}", Color.LightGray, true);
        }
    }

    public void AppendText(string text, Color color, bool AddNewLine = false) {
        if (AddNewLine) {
            text += Environment.NewLine;
        }
        if (this.consoleRTB.InvokeRequired) {
            this.consoleRTB.Invoke(new Action(() => {
                this.consoleRTB.HideSelection = false;
                this.consoleRTB.SelectionStart = this.consoleRTB.TextLength;
                this.consoleRTB.SelectionLength = 0;

                this.consoleRTB.SelectionColor = color;
                this.consoleRTB.AppendText(text);
                this.consoleRTB.SelectionColor = this.consoleRTB.ForeColor;
                this.consoleRTB.Refresh();
            }));
        } else {
            this.consoleRTB.HideSelection = false;
            this.consoleRTB.SelectionStart = this.consoleRTB.TextLength;
            this.consoleRTB.SelectionLength = 0;

            this.consoleRTB.SelectionColor = color;
            this.consoleRTB.AppendText(text);
            this.consoleRTB.SelectionColor = this.consoleRTB.ForeColor;
            this.consoleRTB.Refresh();
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
