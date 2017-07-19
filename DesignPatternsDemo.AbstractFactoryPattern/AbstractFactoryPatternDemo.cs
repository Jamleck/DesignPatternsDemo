using System;
using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class AbstractFactoryPatternDemo : IDemo
    {
        public void Demo()
        {
            Console.WriteLine("Abstract pattern demo...");

            // Get shape factory
            var shapeFactory = FactoryProducer.GetFactory("SHAPE");

            // Get an object of shape circle
            var shape1 = shapeFactory.GetShape("CIRCLE");

            // Draw a circle
            shape1.Draw();

            // Get a rectangle
            var shape2 = shapeFactory.GetShape("RECTANGLE");


            // Draw a rectangle
            shape2.Draw();

            // Get a square
            var shape3 = shapeFactory.GetShape("SQUARE");

            // Draw a square
            shape3.Draw();


            var colorFactory = FactoryProducer.GetFactory("Color");
            var color1 = colorFactory.GetColor("RED");
            var color2 = colorFactory.GetColor("Green");
            var color3 = colorFactory.GetColor("Blue");


            color1.Fill();
            color2.Fill();
            color3.Fill();
        }
    }
}