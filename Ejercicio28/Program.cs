using Shared;

Console.Write("Ingrese la viga: ");
string viga = Console.ReadLine() ?? "";

if (viga.Length == 0)
{
    Console.WriteLine("La viga está mal construida!");
    return;
}

Base baseViga = new Base(viga[0]);

if (baseViga.Resistencia == 0)
{
    Console.WriteLine("La viga está mal construida!");
    return;
}

int pesoTotal = 0;
int cantidadLargueros = 0;

for (int i = 1; i < viga.Length; i++)
{
    char pieza = viga[i];

    if (pieza == '=')
    {
        cantidadLargueros++;
    }
    else if (pieza == '*')
    {
        if (cantidadLargueros == 0)
        {
            Console.WriteLine("La viga está mal construida!");
            return;
        }

        Larguero larguero = new Larguero(cantidadLargueros);
        pesoTotal += larguero.Peso;

        Conexion conexion = new Conexion(cantidadLargueros * 2);
        pesoTotal += conexion.Peso;

        cantidadLargueros = 0;
    }
    else
    {
        Console.WriteLine("La viga está mal construida!");
        return;
    }
}

pesoTotal += cantidadLargueros;

if (pesoTotal <= baseViga.Resistencia)
{
    Console.WriteLine("La viga soporta el peso!");
}
else
{
    Console.WriteLine("La viga NO soporta el peso!");
}
