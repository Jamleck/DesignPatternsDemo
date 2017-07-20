namespace DesignPatternsDemo.BuilderPattern
{
    public class Pepsi : ColdDrink
    {
        public override string Name => "Pepsi";

        public override float Price()
        {
            return 23.5f;
        }
    }
}