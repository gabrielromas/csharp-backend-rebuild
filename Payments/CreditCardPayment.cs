public class CreditCardPayment : IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Plata cu cardul: "+ amount);
    }
}