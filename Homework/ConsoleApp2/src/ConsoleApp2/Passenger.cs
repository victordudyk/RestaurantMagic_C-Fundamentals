using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Passenger
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public int age { get; set; }
        public readonly DateTime dateOfRegistration = DateTime.Now;
        public DateTime DateOfRegistration
        {
            get { return dateOfRegistration; }
        }
        public bool isPrimaryPassenger { get; set; }
    public Passenger(String firstName, String lastName, int age, DateTime dateOfRegistration, bool isPrimaryPassenger)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.dateOfRegistration = dateOfRegistration;
            this.isPrimaryPassenger = isPrimaryPassenger;
        }
    }
}
