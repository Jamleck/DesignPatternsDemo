using System;

namespace DesignPatternsDemo.CommandPattern
{
    public class Stock
    {
        private readonly string name = "ABC";
        private readonly int quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock [Name:" + name + ", Quantity: " + quantity + "] bought");
        }

        public void Sell()
        {
            Console.WriteLine("Stock [Name:" + name + ", Quantity: " + quantity + "] sold");
        }
    }
}