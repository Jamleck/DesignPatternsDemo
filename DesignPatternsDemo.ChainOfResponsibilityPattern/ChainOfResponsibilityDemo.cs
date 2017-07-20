using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.ChainOfResponsibilityPattern
{
    public class ChainOfResponsibilityDemo : IDemo
    {
        public void Demo()
        {
            var logger = new Logger();
            var logChain = logger.GetChainOfLoggers();

            logChain.LogMessage(AbstractLogger.Info, "This is information.");
            logChain.LogMessage(AbstractLogger.Debug, "This is debug.");
            logChain.LogMessage(AbstractLogger.Error, "This is an error information.");
        }
    }
}