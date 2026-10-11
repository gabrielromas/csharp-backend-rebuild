    List<Product> products = new List<Product>
    {
        new Product("Laptop", 3500m, true),
        new Product("Mouse", 120m, true),
        new Product("Tastatura", 250m, false)
    };

    foreach (Product produs in products)
    {
        Console.WriteLine($"{produs.Name} - {produs.Price} lei");
    }

    var totalAvailableProductsOver200 = products
                        .Where(p => p.IsAvailable && p.Price > 200)
                        .Sum(p => p.Price);

    Console.WriteLine("--- Search results ---");
    ProductService productService = new ProductService(products);


    Console.WriteLine("--- Available products ---");

    var availableProducts = productService.GetAvailableProducts();

    foreach (var product in availableProducts)
    {
        Console.WriteLine($"{product.Name} - {product.Price} lei");
    }

    var results = productService.SearchByName("tablet");

    if (results.Any())
    {
        foreach (var product in results)
        {
            Console.WriteLine($"{product.Name} - {product.Price} lei");
        }
    }
    else
    {
        Console.WriteLine("No products found.");
    }