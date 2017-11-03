using System;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Customer
    {
        public String firstName;
        public String lastName;
        public int age;
        public readonly DateTime dateOfRegistration = DateTime.Now;
        protected String address;
        internal int mobileNumber;
        public bool isPrimaryConsumer;
        public virtual DiscountType dt { get; set; }
        public Customer(String firstName, int age, DateTime dateOfRegistration, bool isPrimaryConsumer, DiscountType dt)
        {
            this.firstName = firstName;
            this.age = age;
            this.dateOfRegistration = dateOfRegistration;
            this.isPrimaryConsumer = isPrimaryConsumer;
            this.dt = dt;
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
