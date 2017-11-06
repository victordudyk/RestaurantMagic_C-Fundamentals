namespace Lesson7.Sources
{
    using System;

    public class DiscountCalculator
    {
        public double Calculate(double price, DiscountType discountType)
        {
            return price * (100 - this.GetDiscountPercent(discountType)) / 100;
        }

        private int GetDiscountPercent(DiscountType discountType)
        {
            switch (discountType)
            {
                case DiscountType.Low:
                    return 3;
                case DiscountType.Medium:
                    return 5;
                case DiscountType.High:
                    return 7;
                case DiscountType.None:
                    return 0;
                default:
                    throw new ArgumentOutOfRangeException(nameof(discountType), discountType, null);
            }
        }
    }
}