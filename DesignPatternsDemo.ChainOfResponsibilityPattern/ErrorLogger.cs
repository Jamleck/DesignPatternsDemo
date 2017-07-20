using System;

namespace DesignPatternsDemo.ChainOfResponsibilityPattern
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            Level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine("Error::Logger: " + message);
        }

    }
}