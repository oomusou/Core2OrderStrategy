namespace OrderLibrary
{
    public class RebateStrategy : StrategyInterface
    {
        public double calculatePrice(double price)
        {
            return price - 100.0;
        }
    }
}