class PaymentService
{
    private readonly IPaymentService paymentService;

    public PaymentService (IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }

    public void ProcessPayment(decimal amount)
    {
        paymentService.Pay(amount);
    }
}