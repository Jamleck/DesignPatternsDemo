using System;

namespace DesignPatternsDemo.DecoratorPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("\tShape: Circle");
        }
    }
}