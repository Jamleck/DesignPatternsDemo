namespace DesignPatternsDemo.ChainOfResponsibilityPattern
{
    public class Logger
    {
        public AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.Error);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.Debug);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.Info);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }

    }
}