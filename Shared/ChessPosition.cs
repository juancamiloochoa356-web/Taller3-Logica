namespace Shared;

public class ChessPosition
{
    public char Column { get; }
    public int Row { get; }

    public ChessPosition(string position)
    {
        if (string.IsNullOrWhiteSpace(position) || position.Length != 2)
        {
            throw new ArgumentException("La posición no es válida.");
        }

        Column = char.ToUpper(position[0]);

        if (!char.IsDigit(position[1]))
        {
            throw new ArgumentException("La posición no es válida.");
        }

        Row = int.Parse(position[1].ToString());

        if (Column < 'A' || Column > 'H' || Row < 1 || Row > 8)
        {
            throw new ArgumentException("La posición no es válida.");
        }
    }

    public override string ToString()
    {
        return $"{Row}{Column}";
    }
}
