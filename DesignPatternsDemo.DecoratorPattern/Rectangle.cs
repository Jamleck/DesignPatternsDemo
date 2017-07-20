using System;

namespace DesignPatternsDemo.DecoratorPattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("\tShape: Rectangle");
        }
    }
}