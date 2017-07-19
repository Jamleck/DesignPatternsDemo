namespace DesignPatternsDemo.AbstractFactoryPattern
{
    public class AbstractFactoryPatternDemo
    {

        public void Demo()
        {
            // Get shape factory
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("SHAPE");

            // Get an object of shape circle
            IShape shape1 = shapeFactory.GetShape("CIRCLE");

            // Draw a circle
            shape1.Draw();

            // Get a rectangle
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");


            // Draw a rectangle
            shape2.Draw();

            // Get a square
            IShape shape3 = shapeFactory.GetShape("SQUARE");

            // Draw a square
            shape3.Draw();


            AbstractFactory colorFactory = FactoryProducer.GetFactory("Color");
            IColor color1 = colorFactory.GetColor("RED");
            IColor color2 = colorFactory.GetColor("Green");
            IColor color3 = colorFactory.GetColor("Blue");


            color1.Fill();
            color2.Fill();
            color3.Fill();

        }
    }
}
