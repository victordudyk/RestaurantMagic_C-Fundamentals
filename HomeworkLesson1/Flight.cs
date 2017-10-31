using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    public struct Flight
    {
        public string From;
        public string To;
        public decimal Price;
        FlightType flightType;

        public Flight(string From, string To, decimal Price, FlightType flightType)
        {
            this.From = From;
            this.To = To;
            this.Price = Price;
            this.flightType = flightType;
        }

    }

}
