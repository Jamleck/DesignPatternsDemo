namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
  
        private const string Red = "RED";
        private const string Green = "GREEN";
        private const string Blue = "BLUE";

        public override IShape GetShape(string shapeType)
        {
            return null;
        }

        public override IColor GetColor(string colorType)
        {
            colorType = colorType.ToUpperInvariant();

            switch (colorType)
            {
                case Red:
                    return  new Red();
                case Green:
                    return new Green();
                case Blue:
                    return new Blue();
            }

            return null;
        }
    }
}