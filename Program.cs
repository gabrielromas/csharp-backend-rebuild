
// Product produs = new Product("Laptop", 3500m, true);
// // Console.WriteLine($"Nume: {produs.Nume}");
// // Console.WriteLine($"Pret: {produs.Pret}");
// // Console.WriteLine($"Disponibil: {produs.Disponibil}");

// Product produs2 = new Product("Telefon", 2500m, true);
// // Console.WriteLine($"Nume: {produs2.Nume}");
// // Console.WriteLine($"Pret: {produs2.Pret}");
// // Console.WriteLine($"Disponibil: {produs2.Disponibil}");

// Product produs3 = new Product("Mouse", 150m, false);
// // Console.WriteLine($"Nume: {produs3.Nume}");
// // Console.WriteLine($"Pret: {produs3.Pret}");
// // Console.WriteLine($"Disponibil: {produs3.Disponibil}");

// //Console.WriteLine(produs.GetCodIntern());

// ElectronicProduct laptop = new ElectronicProduct(
//         "MacBook",
//         5000m,
//         true,
//         24
//     );

// // Console.WriteLine($"Nume: {laptop.Nume}");
// // Console.WriteLine($"Pret: {laptop.Pret}");  
// // Console.WriteLine($"Disponibil: {laptop.Disponibil}");
// // Console.WriteLine($"Garantie: {laptop.GarantieLuni} luni");


// Customer customer = new Customer(
//     "Gabriel",
//     "gabriel@example.com"
// );

// Customer customer2 = new Customer(
//     "Ion",
//     "ion@example.com"
// );

// Order order = new Order(
//     1,
//     customer,
//     laptop
// );

// Order order1 = new Order(2,customer2,produs2);
// Console.WriteLine($"Customer: {order1.Customer.Nume}");
// Console.WriteLine($"Product: {order1.Product.Nume}");

// // Console.WriteLine($"Order ID: {order.Id}");
// // Console.WriteLine($"Customer: {order.Customer.Nume}");
// // Console.WriteLine($"Email: {order.Customer.Email}");
// // Console.WriteLine($"Product: {order.Product.Nume}");
// // Console.WriteLine($"Price: {order.Product.Pret}");

    // INotificationService emailNotificationService = new EmailNotificationService();
    // INotificationService smsNotificationService = new SmsNotificationService();

    // emailNotificationService.Send("Salut din C#");
    // smsNotificationService.Send("Salut din C#");

    // INotificationService emailService = new EmailNotificationService();
    // OrderService orderService = new OrderService(emailService);
    // orderService.CreateOrder();

    // IPaymentService payment = new CreditCardPayment();
    // IPaymentService payment1 = new PayPalPayment();

    // payment.Pay(100);
    // payment1.Pay(100);

    // IPaymentService creditCard = new CreditCardPayment();
    // PaymentService paymentService = new PaymentService(creditCard);
    // paymentService.ProcessPayment(25);

    // List<string> produse = new List<string>();

    // produse.Add("Laptop");
    // produse.Add("Mouse");
    // produse.Add("Tastatura");

    // foreach (string produs in produse)
    // {
    //     Console.WriteLine(produs);
    // }

    //List<Product> produse = new List<Product>();

    // produse.Add(new Product("Laptop", 4500, true));
    // produse.Add(new Product("Mouse", 150, true));
    // produse.Add(new Product("Tastatura", 300, false));

    // foreach (Product produs in produse)
    // {
    //     Console.WriteLine($"{produs.Nume} - {produs.Pret} lei");
    // }

    // Console.WriteLine($"Numar produse: {produse.Count}");
    // Console.WriteLine($"Primul produs: {produse[0].Nume}");

    // Dictionary<int, Product> produse = new Dictionary<int, Product>();

    // produse.Add(1, new Product("Laptop", 4500, true));
    // produse.Add(2, new Product("Mouse", 150, true));
    // produse.Add(3, new Product("Tastatura", 300, false));

    // if (produse.TryGetValue(10, out Product? produs))
    // {
    //     Console.WriteLine($"{produs.Nume} - {produs.Pret} lei");
    // }
    // else
    // {
    //     Console.WriteLine("Produsul nu exista.");
    // }

    // HashSet<string> categorii = new HashSet<string>();

    // categorii.Add("Electronice");
    // categorii.Add("Laptopuri");
    // categorii.Add("Electronice");

    // foreach (string categorie in categorii)
    // {
    //     Console.WriteLine(categorie);
    // }

    // List<Product> produse = new List<Product>
    // {
    //     new Product("Laptop", 4500, true),
    //     new Product("Mouse", 150, true),
    //     new Product("Tastatura", 300, false)
    // };

    // var produseScumpe = produse.Where(p => p.Pret > 200);
    // foreach (Product produs in produseScumpe)
    // {
    //     Console.WriteLine(produs.Nume);
    // }

    // var numeProduse = produse.Select(p => p.Nume);

    // foreach (string nume in numeProduse)
    // {
    //     Console.WriteLine(nume);
    // }

    // var rezultat = produse
    // .Where(p => p.Pret > 200)
    // .Select(p => p.Nume);

    // var produs = produse.FirstOrDefault(p => p.Pret >200);

    // if (produs != null)
    // {
    //     Console.WriteLine($"{produs.Nume} - {produs.Pret} lei");
    // }
    // else
    // {
    // Console.WriteLine("Nu exista un produs mai mareS de 200 lei.");
    // }

    // bool existaProdusScump = produse.Any(p => p.Pret > 5000);

    // Console.WriteLine(existaProdusScump);

    // var produseSortate = produse.OrderBy(p => p.Pret);
    // foreach (var p in produseSortate)
    // {
    //     Console.WriteLine(p.Nume + " - " + p.Pret);
    // }


    List<Product> produse = new List<Product>
    {
        new Product("Laptop", 4500, true),
        new Product("Mouse", 150, true),
        new Product("Tastatura", 300, false),
        new Product("Monitor", 1200, true)
    };

    var produs = produse
                    .Where(p => p.Pret > 500) 
                    .OrderByDescending(p => p.Pret)
                    .Select(p => p.Nume);

    foreach(var p in produs)
    {
        Console.WriteLine(p);
    } 


                