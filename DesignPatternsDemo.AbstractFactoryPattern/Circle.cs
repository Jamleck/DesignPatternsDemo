using System;

namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::Draw");
        }
    }
}