using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_4.Methods
{
    #region Cinema Class
    public class Cinema
    {
        public string CinemaName { get; set; }

        private Projector projector;

        private Ticket[] tickets = new Ticket[20];

        public Cinema(string name)
        {
            CinemaName = name;
            projector = new Projector();
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }

            Console.WriteLine("Cinema is full!");
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========== All Tickets ==========");

            foreach (var t in tickets)
            {
                if (t != null)
                    t.PrintTicket();
            }
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========== Process Single Ticket ==========");
            t.PrintTicket();
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n========== Cinema Closed ==========");
            projector.Stop();
        }
    }
    #endregion
}
