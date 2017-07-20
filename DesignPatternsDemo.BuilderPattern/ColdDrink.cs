namespace DesignPatternsDemo.BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name { get; }

        public IPackaging Packaging => new Bottle();

        public abstract float Price();
    }
}