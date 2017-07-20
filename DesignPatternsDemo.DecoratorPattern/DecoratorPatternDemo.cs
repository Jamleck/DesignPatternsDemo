using System;
using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.DecoratorPattern
{
    public class DecoratorPatternDemo : IDemo
    {
        public void Demo()
        {
            IShape circle = new Circle();

            IShape redCircle = new RedShapeDecorator(new Circle());
            IShape redRectangle = new RedShapeDecorator(new Rectangle());


            Console.WriteLine("Circle");
            circle.Draw();

            Console.WriteLine("Circle with red border");
            redCircle.Draw();

            Console.WriteLine("Rectangle with red border");
            redRectangle.Draw();
        }
    }
}