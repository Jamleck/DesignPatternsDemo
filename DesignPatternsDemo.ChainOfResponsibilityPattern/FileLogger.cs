using System;

namespace DesignPatternsDemo.ChainOfResponsibilityPattern
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            Level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine("File::Logger: " + message);
        }

    }
}