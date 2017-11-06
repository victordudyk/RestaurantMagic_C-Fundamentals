namespace Lesson7.Sources
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public event EventHandler PurchaseAdded;

        public Order(List<Purchase> purchases, Customer customer)
        {
            this.Customer = customer;
            this.Purchases = purchases;
            this.Date = DateTime.Today;
            this.PurchaseAdded += this.OnPurchaseAdded;
        }
        
        public List<Purchase> Purchases { get; set; }

        public Customer Customer { get; set; }

        public DateTime Date { get; }

        public bool IsTodayOrder()
        {
            return this.Date == DateTime.Today;
        }

        public void AddPurchase(Purchase purchase)
        {
            this.Purchases.Add(purchase);
            this.OnPurchaseAdded(EventArgs.Empty);
        }

        public void OnPurchaseAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Purchase added!");
        }

        protected virtual void OnPurchaseAdded(EventArgs e)
        {
            EventHandler handler = this.PurchaseAdded;
            handler?.Invoke(this, e);
        }
    }
}