namespace OrderLibrary
{
    public class OrderService
    {
        public double GetPrice(double price)
        {
            var strategy = StrategyFactory.Create(price); 
            return strategy(price);
        }
    }
}