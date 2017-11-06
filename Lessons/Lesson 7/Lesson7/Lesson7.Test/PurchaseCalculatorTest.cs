using Lesson7.Sources;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Lesson7.Test
{
    [TestFixture]
    public class PurchaseCalculatorTest
    {
        [TestCase]
        public void CalculateTest()
        {
            var product = new Product("Product", 10.0d, ProductType.Alcohol);
            var amount = 1.5d;
            var expectedResult = 15.0d;

            var result = PurchaseCalculator.Calculate(product, amount);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase]
        public void CalculateTestProductIsNull()
        {
            Product product = GetProduct();
            var amount = 1.5d;
            var expectedResult = 15.0d;

            var result = PurchaseCalculator.Calculate(product, amount);

            Assert.AreEqual(expectedResult, result);
        }

        private static Product GetProduct()
        {
            return null;
        }
    }
}