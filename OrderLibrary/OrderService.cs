using System;

namespace OrderLibrary
{
    public class OrderService
    {
        public double GetPrice(double price)
        {
            Func<double, Func<double, double>> CreateStrategy =
                (orignalPrice) => price > 1000
                    ? (Func<double, double>) PriceStrategy.CalculateRebatePrice
                    : PriceStrategy.CalculateRebatePrice;

            var strategy = CreateStrategy(price);
            return strategy(price);
        }
    }
}