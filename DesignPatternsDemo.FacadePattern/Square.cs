using System;

namespace DesignPatternsDemo.FacadePattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square::Draw()");
        }
    }
}