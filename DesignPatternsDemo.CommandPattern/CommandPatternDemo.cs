using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.CommandPattern
{
    public class CommandPatternDemo : IDemo
    {
        public void Demo()
        {
            var stock = new Stock();

            var buyStockOrder = new BuyStock(stock);
            var sellStockOrder = new SellStock(stock);


            var broker = new Broker();

            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
}