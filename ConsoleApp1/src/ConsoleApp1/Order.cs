using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        public Purchase purchase;
        public String customer;
        public DateTime dateOfOrder = DateTime.Now;
        public Order(Purchase x)
        {
            this.purchase = x;
        }

        public bool IsTodayOrder()
        {
            return dateOfOrder.Date == DateTime.Now.Date;
        }

        public Purchase Summarize()
        {
            return purchase;
        }
        public void Add(Purchase purchase)
        {

        }

        public Purchase Purchase
        {
            get { return purchase; }
            set { purchase = value; }
        }
        public String Customer
        {
            get { return customer; }
            set { customer = value; }
        }
    }
}
