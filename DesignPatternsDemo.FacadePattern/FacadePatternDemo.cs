using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.FacadePattern
{
    public class FacadePatternDemo : IDemo
    {

        public void Demo()
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();      
        }
    }
}