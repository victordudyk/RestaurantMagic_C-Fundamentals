namespace Lesson7.Sources
{
    public class Purchase
    {
        public Purchase(Product product, double amount)
        {
            this.Product = product;
            this.Amount = amount;
        }

        public Product Product { get; set; }

        public double Amount { get; set; }

        public double Calculate()
        {
            return this.Amount * this.Product.Price;
        }

        public string Summarize()
        {
            return $"{this.Product.Name}, Price: {this.Product.Price}, Amount: {this.Amount}";
        }
    }
}