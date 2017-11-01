using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public String nameVar;
        public double price;
        public String productType;
        public Product(String name, double price, String productType)
        {
            this.nameVar = name;
            this.price = price;
            this.productType = productType;
        }
    }
    //public enum ProductType
    //{
    //    item1,
    //    item2,
    //    item3
    //}
}
