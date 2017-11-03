using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        IPurchase purchase;
        Customer customer;
        public DateTime dateOfOrder = DateTime.Now;
        public Order(IPurchase x, Customer c)
        {
            this.purchase = x;
            this.customer = c;
        }

        public bool IsTodayOrder()
        {
            return dateOfOrder.Date == DateTime.Now.Date;
        }

        public IPurchase Summarize()
        {
            return purchase;
        }
        public void Add(Purchase purchase)
        {

        }

        public IPurchase Purchase
        {
            get { return purchase; }
            set { purchase = value; }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
    }
}
