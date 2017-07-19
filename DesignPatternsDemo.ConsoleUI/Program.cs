using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsDemo.AbstractFactoryPattern;

namespace DesignPatternsDemo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var abstractFactoryPatternDemo = new AbstractFactoryPatternDemo();
            abstractFactoryPatternDemo.Demo();

            Console.Read();
        }
    }
}
