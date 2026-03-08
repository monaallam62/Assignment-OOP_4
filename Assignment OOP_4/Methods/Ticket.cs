using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_4.Methods
{
    #region Ticket Class
    public class Ticket
    {
        public string MovieName { get; set; }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public int TicketId { get; }

        private static int counter = 1;

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            TicketId = counter++;
        }

        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:0.00} EGP");
        }

        public void SetPrice(decimal newPrice)
        {
            Price = newPrice;
            Console.WriteLine($"Setting price directly: {newPrice}");
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price}");
        }

        public static int GetTotalTickets()
        {
            return counter - 1;
        }

        public class StandardTicket : Ticket
        {
            public SeatLocation Seat { get; set; }

            public StandardTicket(string movieName, decimal price, SeatLocation seat)
                : base(movieName, price)
            {
                Seat = seat;
            }

            public override void PrintTicket()
            {
                base.PrintTicket();
                Console.WriteLine($"Seat: {Seat}");
            }
        }

        public class VIPTicket : Ticket
        {
            public bool LoungeAccess { get; set; }

            public decimal ServiceFee { get; } = 50m;

            public VIPTicket(string movieName, decimal price, bool loungeAccess)
                : base(movieName, price)
            {
                LoungeAccess = loungeAccess;
            }

            public override void PrintTicket()
            {
                base.PrintTicket();
                Console.WriteLine($"Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
            }
        }

        public class IMAXTicket : Ticket
        {
            public bool Is3D { get; set; }

            public IMAXTicket(string movieName, decimal price, bool is3D)
                : base(movieName, price)
            {
                Is3D = is3D;
            }

            public override void PrintTicket()
            {
                base.PrintTicket();
                Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
            }
        }
    }
    #endregion
}
