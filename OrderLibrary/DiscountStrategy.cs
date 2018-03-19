namespace OrderLibrary
{
    public class DiscountStrategy : StrategyInterface
    {
        public double calculatePrice(double price)
        {
            return price * 0.80;
        }
    }
}