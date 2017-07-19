using System;

namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        private const string ShapeFactory = "SHAPE";
        private const string ColorFactory = "COLOR";

        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Equals(ShapeFactory, StringComparison.InvariantCultureIgnoreCase))
                return new ShapeFactory();

            if (choice.Equals(ColorFactory, StringComparison.InvariantCultureIgnoreCase))
                return new ColorFactory();

            return null;
        }
    }
}