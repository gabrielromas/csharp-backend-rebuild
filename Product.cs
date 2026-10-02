public class Product
{
    public string Nume { get; set; }
    public decimal Pret { get; set; }
    public bool Disponibil { get; set; }

    private string codIntern = "ABC123";

    public Product(string nume, decimal pret, bool disponibil)
    {
        Nume = nume;
        Pret = pret;
        Disponibil = disponibil;
    }

    public string GetCodIntern()
    {
        return codIntern;
    }
}