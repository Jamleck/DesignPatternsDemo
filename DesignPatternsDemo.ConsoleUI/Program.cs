using System;
using DesignPatternsDemo.AbstractFactoryPattern;
using DesignPatternsDemo.AdapterPattern;
using DesignPatternsDemo.BridgePattern;
using DesignPatternsDemo.BuilderPattern;
using DesignPatternsDemo.ChainOfResponsibilityPattern;
using DesignPatternsDemo.CommandPattern;
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

            var builderPatternDemo = new BuilderPatternDemo();
            RunDemo(builderPatternDemo);

            var chainOfResponsibilityDemo = new ChainOfResponsibilityDemo();
            RunDemo(chainOfResponsibilityDemo);

            var commandPatternDemo = new CommandPatternDemo();
            RunDemo(commandPatternDemo);

            Console.Read();
        }

        private static void RunDemo(IDemo demo)
        {
            demo.Demo();

            Console.WriteLine();
        }
    }
}