namespace Lesson7.Sources
{
    using System;

    public class Customer
    {
        public Customer(string firstName, string lastName, int age, string address, DiscountType discountType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfRegistration = DateTime.Now;
            this.Address = address;
            this.Age = age;
            this.DiscountType = discountType;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime DateOfRegistration { get;  }

        public DiscountType DiscountType { get; set; }

        protected string Address { get; set; }

        protected string MobileNumber { get; set; }
    }
}