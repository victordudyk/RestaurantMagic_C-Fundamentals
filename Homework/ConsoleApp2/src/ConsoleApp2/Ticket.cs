using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ticket
    {
        public Passenger passenger { get; set; }
        public Flight flight { get; set; }
        public double priceOfTicket { get; set; }

        public Ticket(Passenger passenger, Flight flight)
        {
            this.passenger = passenger;
            this.flight = flight;
        }

        public double CalculatePrice()
        {
            return priceOfTicket;                        
        }

        //public String Summarize(String ticket)
        public String Summarize()
        {
            return passenger.firstName + " " +  passenger.lastName + " " + flight.price;
        }
    }
}
