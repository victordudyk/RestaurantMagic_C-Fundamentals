namespace Lesson7.Sources
{
    public class Product
    {
        public Product(string name, double price, ProductType productType)
        {
            this.Name = name;
            this.Price = price;
            this.ProductType = productType;
        }

        public static double DefaultAmount { get; set; } = 1.00;

        public string Name { get; set; }

        public double Price { get; set; }

        public ProductType ProductType { get; set; }
    }
}