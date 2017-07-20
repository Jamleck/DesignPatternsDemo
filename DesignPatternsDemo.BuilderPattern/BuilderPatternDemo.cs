using System;
using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.BuilderPattern
{
    public class BuilderPatternDemo : IDemo
    {
        public void Demo()
        {
            var mealBuilder = new MealBuilder();
            var meal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            meal.ShowItems();
            Console.WriteLine("Total Cost: " + meal.GetCost());


            var nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("\r\nNon-Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());
        }
    }
}