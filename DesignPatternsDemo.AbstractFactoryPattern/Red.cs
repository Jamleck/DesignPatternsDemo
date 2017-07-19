using System;

namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Red::Fill");
        }
    }
}