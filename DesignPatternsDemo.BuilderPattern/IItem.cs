namespace DesignPatternsDemo.BuilderPattern
{
    public interface IItem
    {
        string Name { get; }
        IPackaging Packaging { get; }
        float Price();
    }
}