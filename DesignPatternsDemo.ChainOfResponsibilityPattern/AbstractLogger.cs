namespace DesignPatternsDemo.ChainOfResponsibilityPattern
{
    public abstract class AbstractLogger
    {
        public const int Info = 1;
        public const int Debug = 2;
        public const int Error = 3;

        protected int Level;

        //next element in chain or responsibility
        protected AbstractLogger NextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            NextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (Level <= level)
            {
                Write(message);
            }

            // pass the message to the next logger!
            if (NextLogger != null)
            {
                NextLogger.LogMessage(level, message);
            }
        }

        protected abstract void Write(string message);
    }
}