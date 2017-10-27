using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class TicketCalculator
    {
        public static double Calculate(Ticket ticket)
        {
            return ticket.priceOfTicket;
        }

        public static double Calculate(Passenger passenger, Flight flight)
        {        
            flight.price++;
            return flight.price;
        }
    }
}
