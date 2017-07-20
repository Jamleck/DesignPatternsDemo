namespace DesignPatternsDemo.BuilderPattern
{
    public class Water : ColdDrink
    {
        public override string Name => "Water";

        public override float Price()
        {
            return 234.0f;
        }
    }
}