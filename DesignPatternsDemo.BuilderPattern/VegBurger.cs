namespace DesignPatternsDemo.BuilderPattern
{
    public class VegBurger : Burger
    {
        public override string Name => "Veg Burger";

        public override float Price()
        {
            return 25.0f;
        }
    }
}