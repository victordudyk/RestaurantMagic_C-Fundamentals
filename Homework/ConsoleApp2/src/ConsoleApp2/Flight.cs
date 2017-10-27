using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Flight
    {
        //    8.	Create struct Flight (Route)  with following properties
        //•	From; 
        //•	To;
        //•	Price
        public int from;
        public int to;
        public double price;
        //11.	Add property FilghtType to struct Flight and initialize
        public String flightType;
        //13.	Create private field Passenger.DateOfRegistration; 
        private String passenger;
        //14.	Create protected field Passenger.Address; 
        private String passengerAddress;
        //15.	Create internal field Passenger.MobileNumber;
        private String passengerMobileNumber;
        //9.	Create constructor for struct Flight and initialize properties
        public Flight(int from, int to, int price, String flightType, String passenger, String passengerAddress, String passengerMobileNumber)
        {
            this.from = from;
            this.to = to;
            this.price = price;
            this.flightType = flightType;
            this.passenger = passenger;
            this.passengerAddress = passengerAddress;
            this.passengerMobileNumber = passengerMobileNumber;
        }
    }
    enum FlightType
    {
        Charter,
        Public,
        Service
    }
}
