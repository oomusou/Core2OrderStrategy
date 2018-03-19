using System.Dynamic;

namespace OrderLibrary
{
    public static class StrategyFactory
    {
        public static CalculatePriceDelegate Create(double price)
        {
            return price < 1000
                ? (CalculatePriceDelegate) PriceStrategy.CalculateDiscountPrice
                : PriceStrategy.CalculateRebatePrice;
        }
    }
}