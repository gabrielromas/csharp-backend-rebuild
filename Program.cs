string produs = "Laptop";
decimal pret = 3500.00m;
int cantitate = 2;
bool disponibil = true;

Console.WriteLine(produs);
Console.WriteLine(pret);
Console.WriteLine(cantitate);
Console.WriteLine(disponibil);

decimal total = pret * cantitate;

Console.WriteLine(total);

if (total > 5000)
{
    Console.WriteLine("Comanda mare.");
}
else
{
    Console.WriteLine("Comanda nrmala.");
}