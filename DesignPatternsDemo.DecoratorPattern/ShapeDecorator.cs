namespace DesignPatternsDemo.DecoratorPattern
{
    public abstract class ShapeDecorator : IShape
    {
        private readonly IShape _decoratoratedShape;

        protected ShapeDecorator(IShape decoratoratedShape)
        {
            _decoratoratedShape = decoratoratedShape;
        }

        public virtual void Draw()
        {
            _decoratoratedShape.Draw();
        }
    }
}