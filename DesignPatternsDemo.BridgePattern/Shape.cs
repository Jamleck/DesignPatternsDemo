namespace DesignPatternsDemo.BridgePattern
{
    public abstract class Shape
    {
        protected readonly IDrawApi DrawApi;

        protected Shape(IDrawApi drawApi)
        {
            DrawApi = drawApi;
        }

        public abstract void Draw();
    }
}