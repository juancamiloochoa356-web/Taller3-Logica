namespace Shared;

public class Horse
{
    public ChessPosition Position { get; }

    public Horse(string position)
    {
        Position = new ChessPosition(position);
    }

    public bool IsInConflictWith(Horse other)
    {
        int columnDifference = Math.Abs(Position.Column - other.Position.Column);
        int rowDifference = Math.Abs(Position.Row - other.Position.Row);

        return (columnDifference == 1 && rowDifference == 2) ||
               (columnDifference == 2 && rowDifference == 1);
    }
}
