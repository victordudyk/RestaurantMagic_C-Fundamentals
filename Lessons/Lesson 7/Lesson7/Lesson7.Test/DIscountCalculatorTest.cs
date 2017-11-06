using System.Collections.Generic;
using System.Linq;
using Lesson7.Sources;
using NUnit.Framework;

namespace Lesson7.Test
{
    [TestFixture]
    public class DiscountCalculatorTest
    {
        [TestCase(0d, DiscountType.None, 0d, TestName = "Test case 0")]
        [TestCase(10.0d, DiscountType.None, 10.0d, TestName = "Test case 1")]
        [TestCase(10.0d, DiscountType.Low, 9.6999999999999993d, TestName = "Test case 2")]
        /*[TestCase(10.0d, DiscountType.Medium, 9.5d, TestName = "Test case 3")]
        [TestCase(10.0d, DiscountType.High, 0d, TestName = "Test case 4")]*/
        public void CalculateTest(double price, DiscountType discountType, double expectedPrice)
        {
            IEqualityComparer<Product> prodct;
            var calcultor = new DiscountCalculator();
            var actualResult = calcultor.Calculate(price, discountType);
            
        }

        [TestCase()]
        public void CalculateTestHighDiscount()
        {
            CalculateTest(10.0d, DiscountType.Low, 9.6999999999999993d);
        }

    }
}