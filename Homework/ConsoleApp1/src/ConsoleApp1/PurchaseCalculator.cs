using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PurchaseCalculator
    {        
        public static int Calculate(Product product, int amount)
        {
            int sum;
            sum = amount * product.price;           
            return sum;
        }

        public static int Calculate(Purchase purchase)
        {
            int sum;
            sum = purchase.product.price * purchase.amount;
            return sum;
        }
    }
}
