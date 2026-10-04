public class OrderService
{
    private readonly INotificationService notificationService;

    public OrderService(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    public void CreateOrder()
    {
        Console.WriteLine("Comanda a fost creată.");
        notificationService.Send("Comanda ta a fost creată!");
    }
}