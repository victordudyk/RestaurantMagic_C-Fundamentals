using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    public static class TicketCalculator
    {
        public static decimal Calculate(Ticket t)
        {
            return t.CalculatePrice();
        }

        public static decimal Calculate(Passenger p, Flight f)
        {
            return DiscountCalculator.Calculate(f.Price, p.Discounttype);
        }
    }
}
