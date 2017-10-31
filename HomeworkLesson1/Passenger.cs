using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    public class Passenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPrimaryPassenger { get; set; }
        public DateTime DateOfRegistration { get; }
        protected string Address;
        internal int MobileNumber;

        public DiscountType Discounttype { get; set; }
        public Passenger(string FirstName, string LastName, int Age, bool IsPrimaryPassenger, DiscountType Discounttype)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.IsPrimaryPassenger = IsPrimaryPassenger;
            this.Discounttype = Discounttype;
            //FirstName = "Leo";
            //LastName = "Messi";
            //Age = 29;
            //DateOfRegistration = DateTime.Now;
            //IsPrimaryPassenger = true;
        }

    }
}
