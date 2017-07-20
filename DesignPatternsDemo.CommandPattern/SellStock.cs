namespace DesignPatternsDemo.CommandPattern
{
    public class SellStock : IOrder
    {
        private readonly Stock _stock;

        public SellStock(Stock stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Sell();
        }
    }
}