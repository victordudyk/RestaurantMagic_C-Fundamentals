using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
   
    public class Ticket
    {
        public static Ticket Emptyticket;

        public Passenger Passenger { get; set; }
        public Flight Flight { get; set; }

        public AirplaneRoute AirplaneRoute;
       
        public Ticket(Passenger passenger, Flight flight)
        {
            Passenger = passenger;
            Flight = flight;

        }
        public virtual decimal CalculatePrice()
        {
            return TicketCalculator.Calculate(Passenger, Flight); 
        }

        public string Summarize()

        {
            return string.Format("{2} {3} From: {0} To: {1}", Flight.From, Flight.To, Passenger.FirstName, Passenger.LastName);
        }

    }
   
        
}
