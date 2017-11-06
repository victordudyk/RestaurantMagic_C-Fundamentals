namespace Lesson7.Sources
{
    public static class PurchaseCalculator
    {
        public static double Calculate(Purchase purchase)
        {
            return Calculate(purchase.Product, purchase.Amount);
        }

        public static double Calculate(Product product, double amount)
        {
            return product.Price * amount;
        }
    }
}