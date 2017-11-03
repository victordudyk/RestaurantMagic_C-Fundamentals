using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LessonFive
    {
        public void Order()
        {
            GoldCustomer customerGold = new GoldCustomer("John", 20, DateTime.Now, true, DiscountType.High);
            SilverCustomer customerSilver = new SilverCustomer("Richard", 20, DateTime.Now, true, DiscountType.Medium);            
            BronzeCustomer customerBronze = new BronzeCustomer("Harry", 20, DateTime.Now, true, DiscountType.Low);
            DefaultCustomer customerDefault = new DefaultCustomer("Jerry", 20, DateTime.Now, true, DiscountType.None);

            Product productOne = new Product("Banana", 10, "Fruit");
            Product productTwo = new Product("Apple", 8, "Fruit");
            Product productThree = new Product("Cucumber", 6, "Vegetable");

            IPurchase purchase1 = new Purchase(productOne, 10);
            IPurchase purchase2 = new Purchase(productTwo, 8);
            IPurchase purchase3 = new Purchase(productThree, 6);

            Order order1 = new Order(purchase1, customerGold);
            Order order2 = new Order(purchase1, customerSilver);
            Order order3 = new Order(purchase1, customerBronze);
            Order order4 = new Order(purchase1, customerDefault);

            var listOfOrders = new List<Order>();
            listOfOrders.Add(order1);
            listOfOrders.Add(order2);
            listOfOrders.Add(order3);
            listOfOrders.Add(order4);

            DiscountCalculator dc = new DiscountCalculator();
            double sumOfDiscount = 0;
            for (int i = 0; i < listOfOrders.Count; i++)
            {
                sumOfDiscount = dc.Calculate(listOfOrders[i].Purchase.product.price, listOfOrders[i].Customer.dt);
                Console.WriteLine("Customer sum: " + listOfOrders[i].Customer.firstName + "  " + sumOfDiscount);
            }
            Console.Read();

            SalesPurchase spOne = new SalesPurchase(productOne, purchase1.amount);
            SalesPurchase spTwo = new SalesPurchase(productTwo, purchase2.amount);

            Order orderSP1 = new Order(spOne, customerSilver);
            Order orderSP2 = new Order(spTwo, customerGold);

            var listOfOrdersSP = new List<Order>();
            listOfOrdersSP.Add(orderSP1);
            listOfOrdersSP.Add(orderSP2);

            double sumOfDiscountTwo = 0;
            for (int i = 0; i < listOfOrdersSP.Count; i++)
            {
                sumOfDiscountTwo = listOfOrdersSP[i].Purchase.Calculate();
                //Console.WriteLine("Customer sum: " + listOfOrdersSP[i].Customer.firstName + "  " + sumOfDiscountTwo);
            }
            Console.Read();
        }
    }
}
