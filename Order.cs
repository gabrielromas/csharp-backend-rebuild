public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public Product Product { get; set; }

    public Order(int id, Customer customer, Product product)
    {
        Id = id;
        Customer = customer;
        Product = product;
    }
}