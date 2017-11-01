using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LessonFour
    {
        public void Purchase()
        {
            Customer customer1 = new Customer("John", 20, DateTime.Now, true, DiscountType.High);
            Customer customer2 = new Customer("Richard", 20, DateTime.Now, true, DiscountType.Medium);
            Customer customer3 = new Customer("Jerry", 20, DateTime.Now, true, DiscountType.Low);

            Product productOne = new Product("Banana", 10, "Fruit");
            Product productTwo = new Product("Apple", 8, "Fruit");
            Product productThree = new Product("Cucumber", 6, "Vegetable");
            Product productFour = new Product("Melon", 4, "Fruit");
            Product productFive = new Product("Pear", 2, "Fruit");

            Purchase purchase1 = new Purchase(productOne, 10);
            Purchase purchase2 = new Purchase(productTwo, 8);
            Purchase purchase3 = new Purchase(productThree, 6);
            Purchase purchase4 = new Purchase(productFour, 4);
            Purchase purchase5 = new Purchase(productFive, 2);

            Purchase[] arrayPurchase = new Purchase[5] { purchase1 , purchase2, purchase3, purchase4, purchase5};

            Purchase[][] arrayOfArraysPurchase = new Purchase[2][];
            arrayOfArraysPurchase[0] = new Purchase[2] { purchase1, purchase2 };
            arrayOfArraysPurchase[1] = new Purchase[3] { purchase3, purchase4, purchase5 };

            Order order1 = new Order(purchase1, customer1);
            Order order2 = new Order(purchase2, customer2);
            Order order3 = new Order(purchase3, customer3);

            var listOfOrders = new List<Order>();
            listOfOrders.Add(order1);
            listOfOrders.Add(order2);
            listOfOrders.Add(order3);

            double sumOrder = 0;

            listOfOrders.Remove(order1);
            listOfOrders.Remove(order2);

            foreach (var item in listOfOrders)
            {
                //Console.WriteLine("Index of order is: " + listOfOrders.IndexOf(item));
                var currentsumOrder = item.purchase.amount * item.Purchase.ProductOne.price;
                sumOrder = sumOrder + currentsumOrder;
            }
            //Console.WriteLine("Sum of order is: " + sumOrder);
            //Console.Read();        

            Dictionary<Customer, Purchase[]> dictoinary = new Dictionary<Customer, Purchase[]>();
            dictoinary.Add(customer1, arrayOfArraysPurchase[0]);
            dictoinary.Add(customer2, arrayOfArraysPurchase[1]);
            dictoinary.Add(customer3, arrayOfArraysPurchase[0]);

            dictoinary.Remove(customer1);
            dictoinary.Remove(customer3);
            
            double sumDictionary = 0;

            foreach (var item in dictoinary)
            {
                for (int i = 0; i < item.Value.Length; i++)
                {
                    var currentSumDictionary = item.Value[i].amount;
                    sumDictionary = sumDictionary + currentSumDictionary;
                }
            }
            //Console.WriteLine(sumDictionary);
            //Console.Read();

            //•	Create a list of orders and select name of all products from orders; 
            var listOfOrdersLINQ = new List<Order>();
            listOfOrdersLINQ.Add(order1);
            listOfOrdersLINQ.Add(order2);
            listOfOrdersLINQ.Add(order3);

            //List<String> lpOne = listOfOrdersLINQ.Select(l => l.Purchase.Product.nameVar).ToList();
            //lpOne.ForEach(l => Console.WriteLine(l));
            //Console.Read();

            //List<String> lpTwo = listOfOrdersLINQ.Select(l => l.Purchase.Product.productType).ToList();
            List<String> lpTwo = (from l in listOfOrdersLINQ
                                  where l.Purchase.Product.productType == "Vegetable"
                                  select l.Purchase.Product.nameVar).ToList();
            lpTwo.ForEach(l => Console.WriteLine(l));
            Console.Read();
        }
    }
}
