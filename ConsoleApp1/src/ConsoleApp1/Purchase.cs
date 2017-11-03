using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Purchase : IPurchase
    {
        public Product ProductOne;
        public int amount;
        static double defaultAmount = 1.00;
        public delegate void LogPurchaseInfo(Purchase purchase);
        public event LogPurchaseInfo Add;
        public virtual double Calculate()
        {            
            return product.price * amount;
        }

        public double Summarize()
        {
            throw new NotImplementedException();
        }
        public Purchase(Product x, int y)
        {
            this.ProductOne = x;
            this.amount = y;
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
        public Product product
        {
            get { return ProductOne; }
            set { ProductOne = value; }
        }
        int IPurchase.amount
        {
            get { return this.amount; }
            set { }
        }
    }
}
