using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PurchaseCalculator
    {        
        public static double Calculate(Product product, int amount)
        {
            double sum;
            sum = amount * product.price;           
            return sum;
        }

        public static double Calculate(Purchase purchase)
        {
            double sum;
            sum = purchase.ProductOne.price * purchase.amount;
            return sum;
        }
    }
}
