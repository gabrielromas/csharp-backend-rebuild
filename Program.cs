
Product produs = new Product("Laptop", 3500m, true);
// Console.WriteLine($"Nume: {produs.Nume}");
// Console.WriteLine($"Pret: {produs.Pret}");
// Console.WriteLine($"Disponibil: {produs.Disponibil}");

Product produs2 = new Product("Telefon", 2500m, true);
// Console.WriteLine($"Nume: {produs2.Nume}");
// Console.WriteLine($"Pret: {produs2.Pret}");
// Console.WriteLine($"Disponibil: {produs2.Disponibil}");

Product produs3 = new Product("Mouse", 150m, false);
// Console.WriteLine($"Nume: {produs3.Nume}");
// Console.WriteLine($"Pret: {produs3.Pret}");
// Console.WriteLine($"Disponibil: {produs3.Disponibil}");

//Console.WriteLine(produs.GetCodIntern());

ElectronicProduct laptop = new ElectronicProduct(
        "MacBook",
        5000m,
        true,
        24
    );

// Console.WriteLine($"Nume: {laptop.Nume}");
// Console.WriteLine($"Pret: {laptop.Pret}");  
// Console.WriteLine($"Disponibil: {laptop.Disponibil}");
// Console.WriteLine($"Garantie: {laptop.GarantieLuni} luni");


Customer customer = new Customer(
    "Gabriel",
    "gabriel@example.com"
);

Customer customer2 = new Customer(
    "Ion",
    "ion@example.com"
);

Order order = new Order(
    1,
    customer,
    laptop
);

Order order1 = new Order(2,customer2,produs2);
Console.WriteLine($"Customer: {order1.Customer.Nume}");
Console.WriteLine($"Product: {order1.Product.Nume}");

// Console.WriteLine($"Order ID: {order.Id}");
// Console.WriteLine($"Customer: {order.Customer.Nume}");
// Console.WriteLine($"Email: {order.Customer.Email}");
// Console.WriteLine($"Product: {order.Product.Nume}");
// Console.WriteLine($"Price: {order.Product.Pret}");