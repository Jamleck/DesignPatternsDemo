using System;
using DesignPatternsDemo.AbstractFactoryPattern;
using DesignPatternsDemo.AdapterPattern;
using DesignPatternsDemo.BridgePattern;
using DesignPatternsDemo.BuilderPattern;
using DesignPatternsDemo.ChainOfResponsibilityPattern;
using DesignPatternsDemo.CommandPattern;
using DesignPatternsDemo.CompositePattern;
using DesignPatternsDemo.Core;
using DesignPatternsDemo.DecoratorPattern;
using DesignPatternsDemo.FacadePattern;

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

            var compositePatternDemo = new CompositePatternDemo();
            RunDemo(compositePatternDemo);

            var decoratorPatternDemo = new DecoratorPatternDemo();
            RunDemo(decoratorPatternDemo);

            var facadePatternDemo = new FacadePatternDemo();
            RunDemo(facadePatternDemo);
            
            Console.Read();
        }

        private static void RunDemo(IDemo demo)
        {
            demo.Demo();

            Console.WriteLine();
        }
    }
}