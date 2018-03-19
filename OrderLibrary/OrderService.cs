using System;

namespace OrderLibrary
{
    public class OrderService
    {
        public double GetPrice(double price)
        {
            Func<double, double> CreateStrategy(double originPrice) => 
                originPrice > 1000
                ? (Func<double, double>) PriceStrategy.CalculateRebatePrice
                : PriceStrategy.CalculateDiscountPrice;

            var strategy = CreateStrategy(price); 
            return strategy(price);
        }
    }
}