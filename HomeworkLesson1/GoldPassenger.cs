using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class GoldPassenger : Passenger
    {
        public GoldPassenger(string FirstName, string LastName, int Age, bool IsPrimaryPassenger) : base(FirstName, LastName, Age, IsPrimaryPassenger, DiscountType.High)
        {
        }
    }
}
