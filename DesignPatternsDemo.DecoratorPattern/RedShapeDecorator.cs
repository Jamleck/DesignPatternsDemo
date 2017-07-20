using System;

namespace DesignPatternsDemo.DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        private readonly IShape _decoratoratedShape;

        public RedShapeDecorator(IShape decoratoratedShape) : base(decoratoratedShape)
        {
            _decoratoratedShape = decoratoratedShape;
        }

        public override void Draw()
        {
            _decoratoratedShape.Draw();
            SetRedBoarder(_decoratoratedShape);
        }

        private void SetRedBoarder(IShape decoratoratedShape)
        {
            Console.WriteLine("\tBorder Color: Red");

        }
    }
}