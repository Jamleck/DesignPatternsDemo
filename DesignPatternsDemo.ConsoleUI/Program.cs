using System;
using DesignPatternsDemo.AbstractFactoryPattern;
using DesignPatternsDemo.AdapterPattern;
using DesignPatternsDemo.BridgePattern;
using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var abstractFactoryPatternDemo = new AbstractFactoryPatternDemo();
            RunDemo(abstractFactoryPatternDemo);

            var adapterPatternDemo = new AdapterPatternDemo();
            RunDemo(adapterPatternDemo);

            var bridgePatternDemo = new BridgePatternDemo();
            RunDemo(bridgePatternDemo);

            Console.Read();
        }

        private static void RunDemo(IDemo demo)
        {
            demo.Demo();

            Console.WriteLine();
        }
    }
}