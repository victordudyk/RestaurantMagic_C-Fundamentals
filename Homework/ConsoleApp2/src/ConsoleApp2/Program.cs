using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //•	Create const daysOfWeekCount with value 7 and print it in console application
            const int daysOfWeekCount = 7;
            Console.WriteLine(daysOfWeekCount);
            //•	Create string variable surname with value – “mySurname” and print it in console application
            String surname = "mySurname";
            Console.WriteLine(surname);
            //•	Create decimal variable dollarRate with value – 25
            decimal dollarRate = 25;
            //•	Create variable with using keyword var
            var a = 10;
            //•	Create char variable mySymbol – ‘D’
            char mySymbol = 'D';
            //•	Create byte variable minSpeed with value – 20
            byte minSpeed = 20;
            //•	Create long variable with any value;
            long l = 1024768;
            //•	Create uint variable uint1 with value - 1;  
            uint u = 1;
            //•	Create DateTime variable with current DateTime
            DateTime dateTime = DateTime.Now; //??????????????????????????????????????????????? Почему не такая формулировка? DateTime dateTime2 = new DateTime(); Как сделать аналогичное задание именно с такой формулировкой?       
            //Create double variable with value – 12,42;
            double d = 12.42;           
        }
    }    
}
