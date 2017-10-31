using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class DiscountCalculator
    {
        public static decimal Calculate(decimal price, DiscountType discounttype)
        {

            if (discounttype == DiscountType.None)
            {

                return price;
            }
            else if (discounttype == DiscountType.Low)
            {
                price = (100M - 1)/100M * price;
                return price;
            }
            else if (discounttype == DiscountType.Medium)
            {
                price = (100M -2)/100M * price;
                return price;
            }
            else
            {
                price = (100M - 3)/100M * price;
                return price;
            }
        }
    }
}
