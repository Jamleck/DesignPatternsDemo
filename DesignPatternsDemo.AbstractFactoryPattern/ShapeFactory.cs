namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        private const string Circle = "CIRCLE";
        private const string Rectangle = "RECTANGLE";
        private const string Square = "SQUARE";

        public override IShape GetShape(string shapeType)
        {
            shapeType = shapeType.ToUpper();

            switch (shapeType)
            {
                case Circle:
                    return new Circle();
                case Rectangle:
                    return new Rectangle();
                case Square:
                    return new Square();
            }

            return null;
        }

        public override IColor GetColor(string colorType)
        {
            return null;
        }
    }
}