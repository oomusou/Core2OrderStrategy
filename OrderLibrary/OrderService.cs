using System;

namespace OrderLibrary
{
    public class OrderService
    {
        public double GetPrice(double price)
        {
            return StrategyFactory.Create(price).calculatePrice(price);
        }
    }
}