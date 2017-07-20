namespace DesignPatternsDemo.BuilderPattern
{
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Pepsi());
            meal.AddItem(new Water());

            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}