using Assignment_OOP_4.Enum;
using Assignment_OOP_4.Methods;
using static Assignment_OOP_4.Methods.Ticket;

namespace Assignment_OOP_4
{
    #region Practise Task
    //public class PaymentMethod
    //{
    //    private decimal balance;
    //    public decimal Balance => balance;
    //    public PaymentMethod(decimal initial) { balance = initial; }
    //    protected void SetBalance(decimal val) => balance = val;

    //    public virtual bool Charge(decimal amount)
    //    {
    //        if (amount > balance) return false;
    //        balance -= amount; return true;
    //    }
    //}
    //public class CreditCard : PaymentMethod
    //{
    //    public decimal CreditLimit { get; }
    //    public CreditCard(decimal b, decimal limit) : base(b) { CreditLimit = limit; }

    //    public override bool Charge(decimal amount)
    //    {
    //        if (Balance - amount < -CreditLimit) return false;
    //        SetBalance(Balance - amount); return true;
    //    }
    //}
    //public class DebitCard : PaymentMethod
    //{
    //    public DebitCard(decimal b) : base(b) { }
    //}


    #endregion
    internal class Program
    {
        #region Practise Task
        //public static bool ProcessPayment(PaymentMethod paymentMethod, decimal amount)
        //{
        //    if (paymentMethod == null) return false;
        //    return paymentMethod.Charge(amount);
        //}

        #endregion
        static void Main(string[] args)
        {
            #region Practise Task
            //    CreditCard card01 = new CreditCard(500, 300);
            //    bool Result = ProcessPayment(card01, 700);
            //    if (Result)
            //    {
            //        Console.WriteLine("Payment Successfully");
            //        Console.WriteLine($"Your Current Balance : {card01.Balance}");
            //    }
            //    else
            //        Console.WriteLine("Payment Failed , Insufficient Balance");

            //    DebitCard card02 = new DebitCard(500);
            //    bool Result02 = ProcessPayment(card02, 700);
            //    if (Result02)
            //    {
            //        Console.WriteLine("Payment Successfully");
            //        Console.WriteLine($"Your Current Balance : {card02.Balance}");
            //    }
            //    else
            //        Console.WriteLine("Payment Failed , Insufficient Balance");

            #endregion
            #region Question 1
            //Q1: What is the difference between static binding and dynamic binding? When does each one happen ?
            //Static Bibding:The method call is resolved at compile time it Happens (method overloading - Static methods - Method hiding (new keyword) - Private methods)
            //Dynamic Binding:The method call is resolved at runtime based on the actual object it happens (Virtual methods,method overriding,Interface calls)
            #endregion
            #region Question 2
            //Q2 :  What is the difference between method overloading and method overriding?
            //Method Overloading: Same method name, different parameter lists within the same class (Resolved at compile time,Method signature must differ,Zero performance cost — direct call, no vtable)
            //Method Overriding:Derived class overrides a virtual method from the base class using the override keyword (Resolved at run time)
            #endregion
            #region Question 3
            //Q3 : What keywords are used for Method Overriding? What does each one mean ?
            //Virtual Override
            //virtual: Used in the base class to allow a method to be overridden in a derived class
            //override: Used in the derived class to provide a new implementation of the inherited method and base used in the derived class to call the original method from the base class
            #endregion
            #region Question 4
            //Cinema cinema = new Cinema("VOX");

            //cinema.OpenCinema();

            //SeatLocation seat = new SeatLocation(TypeOfTicket.A, 5);

            //StandardTicket t1 = new StandardTicket("Inception", 150m, seat);
            //VIPTicket t2 = new VIPTicket("Avengers", 200m, true);
            //IMAXTicket t3 = new IMAXTicket("Dune", 180m, false);

            //Console.WriteLine("\n========== SetPrice Test ==========");

            //t1.SetPrice(150m);
            //t1.SetPrice(100m, 1.5m);

            //cinema.AddTicket(t1);
            //cinema.AddTicket(t2);
            //cinema.AddTicket(t3);

            //cinema.PrintAllTickets();

            //Cinema.ProcessTicket(t2);

            //cinema.CloseCinema();
            #endregion

        }
    }
}
