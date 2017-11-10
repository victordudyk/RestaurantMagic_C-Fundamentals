using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class Lessons
    {
        public void Lessons1()
        {
            const byte bDaysOfWeekCount = 7;
            Console.WriteLine(bDaysOfWeekCount);
            string strSureName = "Kondratenko";
            Console.WriteLine(strSureName);
            decimal dDollarRate = 25;
            Console.WriteLine(dDollarRate);
            var vTemp = 100;
            Console.WriteLine("Variable with 'bar' type = " + vTemp);
            char cMySymbol = 'D';
            Console.WriteLine("Variable with 'bhar' type = " + cMySymbol);
            byte bMinSpeed = 20;
            Console.WriteLine("Variable with 'byte' type = " + bMinSpeed);
            long lNumber = 9999999;
            Console.WriteLine("Variable with 'long' type = " + lNumber);
            uint uint1 = 1;
            Console.WriteLine("Variable with 'uint' type = " + uint1);
            DateTime dCurrentDateTime = DateTime.Now;
            Console.WriteLine("Variable with 'Datetime' type = " + dCurrentDateTime);
            double dSomeDouble = 20.42;
            Console.WriteLine("Variable with 'double' type = " + dSomeDouble);
            Console.Read();
        }



        public void Lessons3()
        {
            AirplaneRoute Paris = new AirplaneRoute(new List<Ticket>());


            Flight Paris1 = new HomeworkLesson1.Flight("Kiev", "Paris", 50.5M, FlightType.Charter);

            Passenger AndreyKon = new Passenger("Andrey", "Kondratenko", 32, true, DiscountType.Low);
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
                try
                {


                    decimal t1 = TicketCalculator.Calculate(Tickets[i]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Price for " + Tickets[i].Summarize() + " = ");
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
                catch
                {

                }
                finally
                {

                }
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
            foreach (var ticket in Tickets)
            {

                decimal t1 = TicketCalculator.Calculate(ticket);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Price for " + ticket.Summarize() + " = ");
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
                Console.Write("Price for " + Tickets[j].Summarize() + " = ");
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
                Console.Write("Price for " + Tickets[k].Summarize() + " = ");
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


        public void Lesson4()
        {
            //AirplaneRoute Paris1 = new AirplaneRoute(new List<Ticket>());

            Flight Paris = new HomeworkLesson1.Flight("Kiev", "Paris", 15.5M, FlightType.Charter);
            Flight London = new HomeworkLesson1.Flight("Lviv", "London", 65.0M, FlightType.Charter);

            Passenger AndreyKon = new Passenger("Andrey", "Kondratenko", 32, true, DiscountType.Low);
            Passenger ArtemKam = new Passenger("Artem", "Kamenschikov", 35, true, DiscountType.Medium);
            Passenger AlekseyKur = new Passenger("Aleksey", "Kuryavchenko", 37, true, DiscountType.High);
            Passenger AlexandrKar = new Passenger("Alexandr", "Karamshuk", 50, true, DiscountType.Low);
            Passenger SergeiPoch = new Passenger("Sergei", "Pochinok", 27, true, DiscountType.None);


            var ticket1 = new Ticket(AndreyKon, Paris);
            var ticket2 = new Ticket(ArtemKam, Paris);
            var ticket3 = new Ticket(AlekseyKur, Paris);
            var ticket4 = new Ticket(AlexandrKar, Paris);
            var ticket5 = new Ticket(SergeiPoch, Paris);
            var ticket6 = new Ticket(AndreyKon, London);
            var ticket7 = new Ticket(ArtemKam, London);


            Ticket[] arraytickets = new Ticket[7];
            arraytickets[0] = ticket1;
            arraytickets[1] = ticket2;
            arraytickets[2] = ticket3;
            arraytickets[3] = ticket4;
            arraytickets[4] = ticket5;
            arraytickets[5] = ticket6;
            arraytickets[6] = ticket7;

            Ticket[] arraytickets1 = new Ticket[10];

            Ticket[][] ArrayTickets = new Ticket[2][];
            ArrayTickets[0] = arraytickets;
            ArrayTickets[1] = arraytickets1;


            var TicketsRouteParis = new List<Ticket>();
            TicketsRouteParis.Add(ticket1);
            TicketsRouteParis.Add(ticket2);
            TicketsRouteParis.Add(ticket3);
            TicketsRouteParis.Add(ticket4);
            TicketsRouteParis.Add(ticket5);

            var TicketsRouteLondon = new List<Ticket>();
            TicketsRouteLondon.Add(ticket6);
            TicketsRouteLondon.Add(ticket7);


            var Route1 = new AirplaneRoute(TicketsRouteParis);
            var Route2 = new AirplaneRoute(TicketsRouteLondon);
            var Routes = new List<AirplaneRoute>();
            Routes.Add(Route1);
            Routes.Add(Route2);

            decimal sumRoutes = 0;
            for (var i = 0; i < Routes.Count; i++)
            {

                decimal sum = 0;
                for (var j = 0; j < Routes[i].Tickets.Count; j++)
                {

                    sum = sum + TicketCalculator.Calculate(Routes[i].Tickets[j]); ;
                }
                Console.WriteLine("Price for Route:" + (i + 1) + " = " + sum);
                sumRoutes = sumRoutes + sum;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sum of Routes = " + sumRoutes);
            Console.ResetColor();
            Console.Read();

            //--------------------------•	Remove two AirplaneRoutes from list and calculate sum 
            Routes.Remove(Route2);

            sumRoutes = 0;
            for (var i = 0; i < Routes.Count; i++)
            {

                decimal sum = 0;
                for (var j = 0; j < Routes[i].Tickets.Count; j++)
                {

                    sum = sum + TicketCalculator.Calculate(Routes[i].Tickets[j]); ;
                }
                Console.WriteLine("Price for Route:" + (i + 1) + " = " + sum);
                sumRoutes = sumRoutes + sum;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sum of Routes = " + sumRoutes);
            Console.ResetColor();
            Console.WriteLine();
            Console.Read();

            //----------------•	Find index of all items from list.
            for (var i = 0; i < Routes.Count; i++)
            {
                Console.WriteLine("Index:" + Routes.IndexOf(Routes[i]));
            }
            Console.WriteLine();
            Console.ReadKey();

            //-----------------•	Create dictionary of Tickets with two items and calculate price of all tickets (key is Passenger, value is list of tickets); 

            var AndreyTickets = new List<Ticket>();
            var ArtemTickets = new List<Ticket>();
            foreach (var t in arraytickets)
            {
                if (t.Passenger == AndreyKon)
                {
                    AndreyTickets.Add(t);
                }
                else if (t.Passenger == ArtemKam)
                {
                    ArtemTickets.Add(t);
                }

            }

            var ticketDictionary = new Dictionary<Passenger, List<Ticket>>();
            ticketDictionary.Add(AndreyKon, AndreyTickets);
            ticketDictionary.Add(ArtemKam, ArtemTickets);

            sumRoutes = 0;

            foreach (var t in ticketDictionary)
            {
                decimal sum = 0;
                for (var j = 0; j < t.Value.Count; j++)
                {

                    sum = sum + TicketCalculator.Calculate(t.Value[j]);
                }
                Console.WriteLine("Price for Passenger: {0} = {1}", t.Key.LastName, sum);
                sumRoutes = sumRoutes + sum;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sum of Tickets = " + sumRoutes);
            Console.ResetColor();
            Console.WriteLine();
            Console.ReadKey();

            //----•	Add one more item to dictionary and calculate price of all tickets;


            var AlexTickets = new List<Ticket>();
            foreach (var t in arraytickets)
            {
                if (t.Passenger == AlexandrKar)
                {
                    AlexTickets.Add(t);
                }
            }

            ticketDictionary.Add(AlexandrKar, AlexTickets);

            sumRoutes = 0;

            foreach (var t in ticketDictionary)
            {
                decimal sum = 0;
                for (var j = 0; j < t.Value.Count; j++)
                {

                    sum = sum + TicketCalculator.Calculate(t.Value[j]);
                }
                Console.WriteLine("Price for Passenger: {0} = {1}", t.Key.LastName, sum);
                sumRoutes = sumRoutes + sum;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sum of Tickets = " + sumRoutes);
            Console.ResetColor();
            Console.WriteLine();
            Console.ReadKey();

            //--------------•	Remove two items from list and calculate price of all tickets;

            ticketDictionary.Remove(ArtemKam);
            ticketDictionary.Remove(AlexandrKar);

            sumRoutes = 0;

            foreach (var t in ticketDictionary)
            {
                decimal sum = 0;
                for (var j = 0; j < t.Value.Count; j++)
                {

                    sum = sum + TicketCalculator.Calculate(t.Value[j]);
                }
                Console.WriteLine("Price for Passenger: {0} = {1}", t.Key.LastName, sum);
                sumRoutes = sumRoutes + sum;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sum of Tickets = " + sumRoutes);
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine();

            //------•	Create a list of AirplaneRoute and select name of all Passenger from AirplaneRoutes; 


            var AllPassanger = from route in Routes from ticket in route.Tickets select ticket.Passenger.FirstName;

            // ---select from List off tickets----- var AllPassanger1 = TicketsRouteParis.Select(u => u.Passenger.FirstName);

            foreach (var n in AllPassanger)
                Console.WriteLine(n);
            Console.ReadKey();
            Console.WriteLine();

            //---------•	Create a list of AirplaneRoute and select name of all Passenger from AirplaneRoutes where DiscountType is High; 

            //var selectedHighDiscount = from passanger in TicketsRouteParis
            //                           where passanger.Passenger.Discounttype.Equals(DiscountType.High)
            //                           select passanger;


            var selectedHighDiscount1 = from route in Routes
                                        from ticket in route.Tickets
                                        where ticket.Passenger.Discounttype.Equals(DiscountType.High)
                                       select ticket;

            // ---select from List off tickets-----var selectedHighDiscount2 = TicketsRouteParis.Where(u => u.Passenger.Discounttype.Equals(DiscountType.High));

            foreach (var user in selectedHighDiscount1)
                Console.WriteLine("{0} - {1}", user.Passenger.FirstName, user.Passenger.Discounttype);
            Console.ReadKey();
            Console.WriteLine();


            //------•	Create a list of AirplaneRoute and select name of all Passenger from AirplaneRoutes where discountType is Low and order by descending; 

            var selectedLowDiscountOrderdesc = from route in Routes
                                               from ticket in route.Tickets
                                               where ticket.Passenger.Discounttype.Equals(DiscountType.Low)
                                               orderby ticket.Passenger.FirstName descending
                                               select ticket;

            foreach (var n in selectedLowDiscountOrderdesc)
                Console.WriteLine(n.Passenger.FirstName);

            Console.ReadKey();
            Console.WriteLine();

            //-------•	Create a list of AirplaneRoute, group by Passenger. Name and select From of all Flights; 


            var selectGroupPassenger = TicketsRouteParis.GroupBy(p => p.Passenger.FirstName)
                              .Select(g => new { Name = g.Key, From = String.Join(",", g.Select(x => x.Flight.From).ToArray()) });

            
            foreach (var group in selectGroupPassenger)
                Console.WriteLine("{0}: {1}", group.Name, group.From);

            Console.ReadKey();
            Console.WriteLine();


            //--------------•	Create a list of AirplaneRoute,  select the first or default AirplaneRoute where sum of tickets less than 100;

            var routeLessthen100 = (from route in Routes where route.Tickets.Sum(ticket => ticket.CalculatePrice()) < 100 select route).FirstOrDefault();
         
            Console.WriteLine("Route with sum<100 is: {0} To {1}",routeLessthen100.Tickets[0].Flight.From, routeLessthen100.Tickets[0].Flight.To);
            Console.ReadKey();
            Console.WriteLine();
        }



        public void Lesson5()
        {
            Flight Paris = new HomeworkLesson1.Flight("Kiev", "Paris", 50.5M, FlightType.Charter);
            Flight London = new HomeworkLesson1.Flight("Lviv", "London", 65.0M, FlightType.Charter);

            Passenger VadimKlim = new GoldPassenger("Vadim", "Klimenko", 29, false);
            Passenger AlexandrKar = new GoldPassenger("Alexandr", "Karamshuk", 50, false);
            Passenger AndreyKon = new GoldPassenger("Andrey", "Kondratenko", 32, false);
            Passenger ArtemKam = new SilverPassanger("Artem", "Kamenschikov", 35, true);
            Passenger AlekseyKur = new SilverPassanger("Aleksey", "Kuryavchenko", 37, true);
            Passenger IlyaLutsk = new SilverPassanger("Ilya", "Lutskiy", 29, true);




            var t1 = new Ticket(AndreyKon, Paris);
            var t2 = new Ticket(ArtemKam, Paris);
            var t3 = new Ticket(AlekseyKur, Paris);
            var t4 = new Ticket(AlexandrKar, Paris);
            var t5 = new Ticket(VadimKlim, Paris);
            var t6 = new Ticket(AndreyKon, London);
            var t7 = new Ticket(ArtemKam, London);
            var t8 = new Ticket(IlyaLutsk, London);


            var TicketsRouteParis = new List<Ticket>();
            TicketsRouteParis.Add(t1);
            TicketsRouteParis.Add(t2);
            TicketsRouteParis.Add(t3);
            TicketsRouteParis.Add(t4);
            TicketsRouteParis.Add(t5);

            var TicketsRouteLondon = new List<Ticket>();
            TicketsRouteLondon.Add(t6);
            TicketsRouteLondon.Add(t7);
            TicketsRouteLondon.Add(t8);


            var Route1 = new AirplaneRoute(TicketsRouteParis);
            var Route2 = new AirplaneRoute(TicketsRouteLondon);
            var Routes = new List<AirplaneRoute>();
            Routes.Add(Route1);
            Routes.Add(Route2);

            for (var i = 0; i < Routes.Count; i++)
            {
                decimal sum = 0;
                var route = Routes[i];
                for (var j = 0; j < Routes[i].Tickets.Count; j++)
                {
                    sum = sum + TicketCalculator.Calculate(route.Tickets[j]);
                    Console.WriteLine("Passenger: {0} {1} with discount: {2} - From: {3} To: {4} by price: {5} Paid: {6} ", route.Tickets[j].Passenger.FirstName, route.Tickets[j].Passenger.LastName, route.Tickets[j].Passenger.Discounttype, route.Tickets[j].Flight.From, route.Tickets[j].Flight.To, route.Tickets[j].Flight.Price, TicketCalculator.Calculate(route.Tickets[j]));
                }
            }
            Console.ReadKey();

            Console.WriteLine();

            var bt1 = new BestTicket(AndreyKon, Paris);
            var bt2 = new BestTicket(ArtemKam, Paris);
            var bt3 = new BestTicket(AlekseyKur, Paris);
            var bt4 = new BestTicket(AlexandrKar, Paris);
            var bt5 = new BestTicket(VadimKlim, Paris);
            var bt6 = new BestTicket(AndreyKon, London);
            var bt7 = new BestTicket(ArtemKam, London);
            var bt8 = new BestTicket(IlyaLutsk, London);

            var BestTickets = new List<Ticket>();
            BestTickets.Add(bt1);
            BestTickets.Add(bt2);
            BestTickets.Add(bt3);
            BestTickets.Add(bt4);
            BestTickets.Add(bt5);
            BestTickets.Add(bt6);
            BestTickets.Add(bt7);
            BestTickets.Add(bt8);
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------Best Tickets Calculation-------");
            
            foreach (var t in BestTickets)
            {
                decimal sum = 0;
                sum = sum + TicketCalculator.Calculate(t);
                Console.WriteLine("Passenger: {0} {1} with discount: {2} - From: {3} To: {4} by price: {5} Paid: {6} ", t.Passenger.FirstName, t.Passenger.LastName, t.Passenger.Discounttype, t.Flight.From, t.Flight.To, t.Flight.Price, TicketCalculator.Calculate(t));
            }
            Console.ReadKey();
           
        }
     
    }
    

}
