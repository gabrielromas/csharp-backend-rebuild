
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }

    private string internalCode = "ABC123";

    public Product(string name, decimal price, bool isAvailable)
    {
        Name = name;
        Price = price;
        IsAvailable = isAvailable;
    }

    public string GetInternalCode()
    {
        return internalCode;
    }
}