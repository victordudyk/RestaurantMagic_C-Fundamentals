using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GoldCustomer : Customer
    {
        public GoldCustomer(String firstName, int age, DateTime dateOfRegistration, bool isPrimaryConsumer, DiscountType dt) : base(firstName, age, dateOfRegistration, isPrimaryConsumer, DiscountType.High)
        {               
        }
    }
}
