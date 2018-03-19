namespace OrderLibrary
{
    public static class PriceStrategy
    {
        public static double CalculateRebatePrice(double price)
        {
            return price - 100.0;
        }

        public static double CalculateDiscountPrice(double price)
        {
            return price * 0.8;
        }
    }
}