namespace DesignPatternsDemo.BuilderPattern
{
    public class ChickenBurger : Burger
    {
        public override string Name => "Chicken Burger";

        public override float Price()
        {
            return 50.5f;
        }
    }
}