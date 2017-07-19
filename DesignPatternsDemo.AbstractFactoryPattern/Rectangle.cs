using System;

namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::Draw");
        }
    }
}