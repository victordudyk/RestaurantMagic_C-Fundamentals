using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class BestTicket : Ticket
    {
        public BestTicket(Passenger passenger, Flight flight) : base(passenger, flight)
        {

        }

        public override decimal CalculatePrice()
        {
            return base.CalculatePrice()*0.9M;
        }
    }
}
