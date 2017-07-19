using System;
using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.BridgePattern
{
    public class BridgePatternDemo : IDemo
    {
        public void Demo()
        {

            Console.WriteLine("Bridge pattern demo...");

            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());
            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}