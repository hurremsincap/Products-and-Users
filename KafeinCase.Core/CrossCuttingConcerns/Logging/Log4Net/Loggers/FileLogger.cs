using log4net;

namespace KafeinCase.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class FileLogger : LoggerService
    {
        public FileLogger() : base(LogManager.GetLogger("JsonFileLogger"))
        {
        }
        // loggerların kullanılması için Manager dosyasındaki fonksiyonların başına
        // [LogAspect(typeof(DatabaseLogger))] yazılmalı.
    }
}
