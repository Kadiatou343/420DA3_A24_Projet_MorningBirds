using Project_Utilities.Enums;

namespace Project_Utilities.Services.Abstracts;
public interface ILogger {

    public void SetLoggingLevel(LoggingLevelsEnum level);

    public void Start();

    public void Debug(object obj);
    public void Info(object obj);
    public void Success(object obj);
    public void Warn(object obj);
    public void Error(object obj);
    public void Critical(object obj);

}
