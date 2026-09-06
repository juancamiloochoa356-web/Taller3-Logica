namespace Shared;

public class Base
{
    public char Tipo { get; }
    public int Resistencia { get; }

    public Base(char tipo)
    {
        Tipo = tipo;

        Resistencia = tipo switch
        {
            '%' => 10,
            '&' => 30,
            '#' => 90,
            _ => 0
        };
    }
}
