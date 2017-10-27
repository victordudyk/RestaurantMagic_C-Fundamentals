using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DiscountCalculator
    {
        public double Calculate(double price, DiscountType discountType)
        {
            switch (discountType)
            {               
                case DiscountType.Low: return price * 0.97;
                case DiscountType.Medium: return price * 0.95;
                case DiscountType.High: return price * 0.93;
                default: return price;
            } 
        }
    }
}
