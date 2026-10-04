public class ElectronicProduct : Product
{
    public int GarantieLuni { get; set; }

    public ElectronicProduct(
        string nume,
        decimal pret,
        bool disponibil,
        int garantieLuni)
        : base(nume, pret, disponibil)
    {
        GarantieLuni = garantieLuni;
    }
}