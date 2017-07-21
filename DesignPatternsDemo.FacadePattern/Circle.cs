using System;

namespace DesignPatternsDemo.FacadePattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square::Draw()");
        }
    }
}