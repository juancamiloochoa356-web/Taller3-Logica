using Shared;

Console.Write("Ingrese ubicación de los caballos: ");
string input = Console.ReadLine() ?? string.Empty;

string[] positions = input.Split(
    ',',
    StringSplitOptions.RemoveEmptyEntries |
    StringSplitOptions.TrimEntries);

List<Horse> horses = new List<Horse>();

foreach (string position in positions)
{
    horses.Add(new Horse(position));
}

foreach (Horse horse in horses)
{
    Console.Write($"Analizando Caballo en {horse.Position} =>");

    var conflicts = new List<Horse>();

    foreach (Horse otherHorse in horses)
    {
        if (horse == otherHorse)
        {
            continue;
        }

        if (horse.IsInConflictWith(otherHorse))
        {
            conflicts.Add(otherHorse);
        }
    }

    conflicts = conflicts
        .OrderByDescending(h => h.Position.Row)
        .ThenBy(h => h.Position.Column)
        .ToList();

    foreach (Horse conflict in conflicts)
    {
        Console.Write($" Conflicto con {conflict.Position}");
    }

    Console.WriteLine();
}
