using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    public class AirplaneRoute
    {
        public event EventHandler TicketAdded;
        public Airplane Airplane { get; set; }
        public List<Ticket> Tickets { get; set; }
        public DateTime Date { get; set; }

        public AirplaneRoute(List<Ticket> ticket)
        {
            Tickets = ticket;
           
        }


        public void AddTicket(Ticket ticket)
        {
            this.Tickets.Add(ticket);
            this.OnTicketAdded(EventArgs.Empty);
        }

        public void OnTicketAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Ticket added!");
        }

        protected virtual void OnTicketAdded(EventArgs e)
        {
            EventHandler handler = TicketAdded;
            handler?.Invoke(this, e);
        }
        //public void Add(Ticket ticket)
        //{
        //    Tickets.Add(ticket);

        //    if (TicketAdded != null)
        //    { TicketAdded(ticket); }

        //    if (TicketAddedEA!= null)
        //    {
        //        var e = new ea2();
        //        e.Cancel = false;
        //        e.Ticket = ticket;

        //        TicketAddedEA(this, e);

        //        if (e.Cancel)
        //        {
        //            ;
        //        }
        //    }
        //}

        //    public event LogTicketInfo TicketAdded;
        //    public event EventHandler<ea2> TicketAddedEA;
        //}

        //public class ea2 : EventArgs
        //{
        //    public bool Cancel;
        //    public Ticket Ticket;
        //}
    }
}
