using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DiscountCalculator dc = new DiscountCalculator();
            dc.Calculate(10, DiscountType.None);
            dc.Calculate(10, DiscountType.Low);
            dc.Calculate(10, DiscountType.Medium);
            dc.Calculate(10, DiscountType.High);
            var purchase = new List<Purchase>();
            LessonFour lFour = new LessonFour();
            //lFour.Purchase();
            LessonFive lFive = new LessonFive();
            lFive.Order();
        }
    }     
}
