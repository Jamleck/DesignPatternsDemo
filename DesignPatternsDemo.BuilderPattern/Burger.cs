namespace DesignPatternsDemo.BuilderPattern
{
    public abstract class Burger : IItem
    {
        public abstract string Name { get; }


        public IPackaging Packaging => new Wrapper();

        public abstract float Price();
    }
}