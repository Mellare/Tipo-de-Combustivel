int x = 0;// Álcool
int y = 0;//Gasolina
int z = 0;//Diesel

bool entraNoLaco = true;

while(entraNoLaco)
{

int codigo = int.Parse(Console.ReadLine());


if(codigo == 1)
{
    x = x + 1;
}

if(codigo == 2)
{
    y = y + 1;
}

if(codigo == 3)
{
    z = z + 1;
}

if(codigo == 4)
{
    entraNoLaco = false;
}

}
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: " + x);
Console.WriteLine("Gasolina: " + y);
Console.WriteLine("Diesel: " + z);
