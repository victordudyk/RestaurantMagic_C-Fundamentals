using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class SilverPassanger : Passenger
    {
        public SilverPassanger(string FirstName, string LastName, int Age, bool IsPrimaryPassenger) : base(FirstName, LastName, Age, IsPrimaryPassenger, DiscountType.Medium)
        {
        }
    }
}
