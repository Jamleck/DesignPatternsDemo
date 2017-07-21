using System;

namespace DesignPatternsDemo.FacadePattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle::Draw()");
        }
    }
}