using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Purchase
    {
        public Product product;
        public int amount;
        static double defaultAmount = 1.00;
        public delegate void LogPurchaseInfo(Purchase purchase);
        public event LogPurchaseInfo Add;
        public int Calculate(int amount)
        {            
            return Product.price * amount;
        }
        public Product Product
        {
            get { return Product; }
            set { product = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double DefaultAmount
        {
            get { return defaultAmount; }
            set { defaultAmount = value; }
        }
    }
}
