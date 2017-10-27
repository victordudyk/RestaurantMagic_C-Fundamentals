using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AirplaneRoute
    {
        Airplane airplane { get; set; }
        Ticket tickets  { get; set; }
        DateTime date { get; set; }

        public AirplaneRoute(Airplane airplane, Ticket tickets)
        {
            this.airplane = airplane;
            this.tickets = tickets;
        }

        public bool IsTodayFlight()
        {
            return date.Equals(DateTime.Now);
        }
    }
}
