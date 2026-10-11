
using System;
using System.Collections.Generic;
using System.Linq;

public class ProductService
{
    private readonly List<Product> products;

    public ProductService(List<Product> products)
    {
        this.products = products;
    }

    public List<Product> SearchByName(string searchText)
    {
        return products
            .Where(p => p.Name.Contains(
                searchText,
                StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Product> GetAvailableProducts()
    {
        return products
            .Where(p => p.IsAvailable)
            .ToList();
    }
}