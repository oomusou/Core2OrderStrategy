using System;

namespace OrderLibrary
{
    public static class StrategyFactory
    {
        public static Func<double, double> Create(double price)
        {
            return price < 1000
                ? (Func<double, double>) PriceStrategy.CalculateDiscountPrice
                : PriceStrategy.CalculateRebatePrice;
        }
    }
}