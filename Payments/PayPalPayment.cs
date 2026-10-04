public class PayPalPayment : IPaymentService
{
    void IPaymentService.Pay(decimal amount)
    {
        Console.WriteLine("Plata prin PayPal: " + amount);
    }
}