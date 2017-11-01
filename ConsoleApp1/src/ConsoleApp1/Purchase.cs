using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Purchase
    {
        public Product ProductOne;
        public double amount;
        static double defaultAmount = 1.00;
        public delegate void LogPurchaseInfo(Purchase purchase);
        public event LogPurchaseInfo Add;
        public virtual double Calculate(double amount)
        {            
            return Product.price * amount;
        }
        public Purchase(Product x, double y)
        {
            this.ProductOne = x;
            this.amount = y;
        }
        public Product Product
        {
            get { return ProductOne; }
            set { ProductOne = value; }
        }
        public double Amount
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
