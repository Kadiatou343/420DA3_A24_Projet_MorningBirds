using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Services;
public class LoggingService : AbstractService {
    private readonly List<ILogger> loggers = new List<ILogger>();
    private readonly Queue<LoggingTask> loggingTaskQueue = new Queue<LoggingTask>();


    public LoggingService(IServiceContainer parent) : base(parent) {
        this.Starting += this.StartLoggers;
        this.Started += this.ProcessQueue;
    }


    public void RegisterLogger(ILogger logger) {
        this.loggers.Add(logger);
    }


    public void Debug(object obj) {
        this.loggingTaskQueue.Enqueue(new LoggingTask(obj, LoggingLevelsEnum.DEBUG));
    }

    public void Info(object obj) {
        this.loggingTaskQueue.Enqueue(new LoggingTask(obj, LoggingLevelsEnum.INFO));
    }

    public void Success(object obj) {
        this.loggingTaskQueue.Enqueue(new LoggingTask(obj, LoggingLevelsEnum.SUCCESS));
    }

    public void Warn(object obj) {
        this.loggingTaskQueue.Enqueue(new LoggingTask(obj, LoggingLevelsEnum.WARNING));
    }

    public void Error(object obj) {
        this.loggingTaskQueue.Enqueue(new LoggingTask(obj, LoggingLevelsEnum.ERROR));
    }

    public void Critical(object obj) {
        this.loggingTaskQueue.Enqueue(new LoggingTask(obj, LoggingLevelsEnum.CRITICAL));
    }

    private void StartLoggers(IStartable startable) {
        foreach (ILogger logger in this.loggers) {
            logger.Start();
        }
    }

    private async void ProcessQueue(IStartable startable) {
        await Task.Run(() => {
            while (this.IsStarted()) {
                if (this.loggingTaskQueue.Count > 0) {
                    LoggingTask task = this.loggingTaskQueue.Dequeue();
                    task.Execute(this.loggers);
                }
                Thread.Sleep(100);
            }
        });
    }
}
