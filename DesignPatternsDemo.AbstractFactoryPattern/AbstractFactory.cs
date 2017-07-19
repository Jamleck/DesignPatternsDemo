namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeType);

        public abstract IColor GetColor(string colorType);
    }
}