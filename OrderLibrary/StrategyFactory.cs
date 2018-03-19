using System.Dynamic;

namespace OrderLibrary
{
    public static class StrategyFactory
    {
        public static StrategyInterface Create(double price)
        {
            return price < 1000 ? (StrategyInterface) new DiscountStrategy() : new RebateStrategy();
        }
    }
}