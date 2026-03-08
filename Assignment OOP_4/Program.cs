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
        }
    }
}
