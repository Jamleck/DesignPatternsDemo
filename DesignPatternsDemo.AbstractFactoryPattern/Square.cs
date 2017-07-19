using System;

namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::Draw");
        }
    }
}