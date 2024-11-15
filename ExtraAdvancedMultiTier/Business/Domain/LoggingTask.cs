using Project_Utilities.Enums;
using Project_Utilities.Services.Abstracts;

namespace ExtraAdvancedMultiTier.Business.Domain;
internal class LoggingTask {
    public object Input { get; }
    public LoggingLevelsEnum Level { get; }

    public LoggingTask(object input, LoggingLevelsEnum level) {
        this.Input = input;
        this.Level = level;
    }

    public void Execute(IEnumerable<ILogger> loggers) {
        List<Task> tasks = new List<Task>();
        foreach (ILogger logger in loggers) {
            tasks.Add(Task.Run(() => {
                switch (this.Level) {
                    case LoggingLevelsEnum.DEBUG:
                        logger.Debug(this.Input);
                        break;
                    case LoggingLevelsEnum.INFO:
                        logger.Info(this.Input);
                        break;
                    case LoggingLevelsEnum.SUCCESS:
                        logger.Success(this.Input);
                        break;
                    case LoggingLevelsEnum.WARNING:
                        logger.Warn(this.Input);
                        break;
                    case LoggingLevelsEnum.ERROR:
                        logger.Error(this.Input);
                        break;
                    case LoggingLevelsEnum.CRITICAL:
                        logger.Critical(this.Input);
                        break;
                }
            }));
        }
        Task.WaitAll(tasks.ToArray());
    }

}
