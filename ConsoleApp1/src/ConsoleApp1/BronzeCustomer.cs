﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BronzeCustomer : Customer
    {
        public BronzeCustomer(string firstName, int age, DateTime dateOfRegistration, bool isPrimaryConsumer, DiscountType dt) : base(firstName, age, dateOfRegistration, isPrimaryConsumer, DiscountType.Low)
        {
        }
    }
}
