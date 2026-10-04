public class Customer
{
    public string Nume { get; set; }
    public string Email { get; set; }

    public Customer(string nume, string email)
    {
        Nume = nume;
        Email = email;
    }
}