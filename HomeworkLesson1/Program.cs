using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class Program
    {

        static void Main(string[] args)
        {
            //const byte bDaysOfWeekCount = 7;
            //Console.WriteLine(bDaysOfWeekCount);
            //string strSureName = "Kondratenko";
            //Console.WriteLine(strSureName);
            //decimal dDollarRate = 25;
            //Console.WriteLine(dDollarRate);
            //var vTemp = 100;
            //Console.WriteLine("Variable with 'bar' type = " +  vTemp);
            //char cMySymbol = 'D';
            //Console.WriteLine("Variable with 'bhar' type = " + cMySymbol);
            //byte bMinSpeed = 20;
            //Console.WriteLine("Variable with 'byte' type = " + bMinSpeed);
            //long lNumber = 9999999;
            //Console.WriteLine("Variable with 'long' type = " + lNumber);
            //uint uint1 = 1;
            //Console.WriteLine("Variable with 'uint' type = " + uint1);
            //DateTime dCurrentDateTime = DateTime.Now;
            //Console.WriteLine("Variable with 'Datetime' type = " + dCurrentDateTime);
            //double dSomeDouble = 20.42;
            //Console.WriteLine("Variable with 'double' type = " + dSomeDouble);
            //Console.Read();


            

            AirplaneRoute Paris = new AirplaneRoute();
            Paris.Date = new DateTime(2017, 11, 3);

            Paris.Airplane = new Airplane();
            Paris.Airplane.Name = "lll";
            Paris.Airplane.Capacity = 100;

            Flight Paris1 = new HomeworkLesson1.Flight("Kiev", "Paris", 50.5M, FlightType.Charter);

            Passenger AndreyKon = new Passenger("Andrey","Kondratenko",32,true,DiscountType.Low);
            Passenger ArtemKam = new Passenger("Artem", "Kamenschikov", 35, true, DiscountType.Medium);
            Passenger AlekseyKur = new Passenger("Aleksey", "Kuryavchenko", 37, true, DiscountType.High);
            Passenger AlexandrKar = new Passenger("Alexandr", "Karamshuk", 50, true, DiscountType.Low);
            Passenger SergeiPoch = new Passenger("Sergei", "Pochinok", 27, true, DiscountType.None);


            var ticket1 = new Ticket(AndreyKon, Paris1);
            var ticket2 = new Ticket(ArtemKam, Paris1);
            var ticket3 = new Ticket(AlekseyKur, Paris1);
            var ticket4 = new Ticket(AlexandrKar, Paris1);
            var ticket5 = new Ticket(SergeiPoch, Paris1);


            var Tickets = new List<Ticket>();
            Tickets.Add(ticket1);
            Tickets.Add(ticket2);
            Tickets.Add(ticket3);
            Tickets.Add(ticket4);
            Tickets.Add(ticket5);

//------------------------- for ------------------------------

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------This is example'FOR'-----------------------");
            decimal sum = 0;
            decimal discsum = 0;
            for (var i = 0; i < Tickets.Count; i++)
            {
                
                decimal t1 = TicketCalculator.Calculate(Tickets[i]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Price for "+ Tickets[i].Summarize()+" = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(t1);

                decimal disc = Tickets[i].Flight.Price - t1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Discount is: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(disc);
                sum = sum + t1;
                discsum = discsum + disc;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total Price = {0}", sum);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Total Discount = {0}", discsum);
            Console.ResetColor();

            Console.ReadKey();


            //------------------------- for each------------------------------
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------This is example'FOR EACH'-------------------");
            sum = 0;
            discsum = 0;
            foreach (var ticket in  Tickets)
            {

                decimal t1 = TicketCalculator.Calculate(ticket);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Price for "+ ticket.Summarize() + " = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(t1);
                decimal disc = ticket.Flight.Price - t1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Discount is: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(disc);
                sum = sum + t1;
                discsum = discsum + disc;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total Price= {0}", sum);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Total Discount= {0}", discsum);
            Console.ResetColor();
            Console.ReadKey();

            //------------------------- while------------------------------
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------This is example'WHILE'----------------------");
            sum = 0;
            discsum = 0;
            int j = 0;
            while (j < Tickets.Count)
            {

                decimal t1 = TicketCalculator.Calculate(Tickets[j]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Price for "+ Tickets[j].Summarize() + " = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(t1);
                decimal disc = Tickets[j].Flight.Price - t1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Discount is: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(disc);
                sum = sum + t1;
                discsum = discsum + disc;
                j++;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total Price= {0}", sum);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Total Discount= {0}", discsum);
            Console.ResetColor();

            Console.ReadKey();

            //------------------------- do  while------------------------------
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------This is example'DO WHILE'-------------------");
            sum = 0;
            discsum = 0;
            int k = 0;
            do
            {

                decimal t1 = TicketCalculator.Calculate(Tickets[k]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Price for "+ Tickets[k].Summarize() + " = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(t1);
                decimal disc = Tickets[k].Flight.Price - t1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Discount is: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(disc);
                sum = sum + t1;
                discsum = discsum + disc;
                k++;
            } while (k < Tickets.Count);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total Price= {0}", sum);
        

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Total Discount= {0}", discsum);
            Console.ResetColor();

            Console.ReadKey();
        }
      
    }
 
   
}
