using System;

namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue::Fill");
        }
    }
}