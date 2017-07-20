using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsDemo.BuilderPattern
{
    public class Meal
    {
        private readonly List<IItem> _items = new List<IItem>();

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public float GetCost()
        {
            var cost = _items.Select(c => c.Price()).Sum();

            return cost;
        }


        public void ShowItems()
        {
            foreach (var item in _items)
            {
                Console.Write("Item: " + item.Name);
                Console.Write(", Packaging: " + item.Packaging.Pack());
                Console.WriteLine(", Price: " + item.Name);
            }
        }
    }
}