
string nume = "Mere";
int pret = 10;
double cantitate = 2299.5;
bool disponibil = true;
int i = 5;
double total = cantitate * pret;

Console.WriteLine(nume);
Console.WriteLine(total);

if (disponibil)
{
    Console.WriteLine("Disponobil.");
}
else
{
    Console.WriteLine("Indisponibil");
}

if(total > 5000)
{
    Console.WriteLine("Comanda mare.");
}
else
{
    Console.WriteLine("Comanda normala.");
}

for (int j = 1; j<=5; j++)
{
    Console.WriteLine(j);
}

while (i > 0)
{
    Console.WriteLine(i);
    i--;
}