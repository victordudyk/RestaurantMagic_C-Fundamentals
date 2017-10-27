﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        public String firstName;
        public String lastName;
        public int age;
        public readonly DateTime dateOfRegistration = DateTime.Now;
        protected String address;
        internal int mobileNumber;
        public bool isPrimaryConsumer;
        public Customer()
        {
            firstName = "John";
            lastName = "Snow";
            age = 27;
            dateOfRegistration = new DateTime(2010, 1, 1);
            isPrimaryConsumer = true;
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public DateTime DateOfRegistration
        {
            get { return dateOfRegistration; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public int MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public bool IsPrimaryConsumer
        {
            get;
            set;
        }
        public Customer DiscountCalculator
        { get;
          set;
        }
    }   
}