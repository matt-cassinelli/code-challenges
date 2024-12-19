// https://www.codingame.com/training/easy/power-of-thor-episode-1

static void Main(string[] args)
{
    var (light, thor) = ExtractInput();
    while (true)
    {
        int remainingTurns = int.Parse(Console.ReadLine()); // Needed for engine - do not remove
        thor.MoveTowards(light);
    }
}

private static (Point light, Thor thor) ExtractInput()
{
    string[] inputs = Console.ReadLine().Split(' ');
    int lightX = int.Parse(inputs[0]);
    int lightY = int.Parse(inputs[1]);
    int thorX = int.Parse(inputs[2]);
    int thorY = int.Parse(inputs[3]);
    return (
        new Point(lightX, lightY),
        new Thor(new Point(thorX, thorY), "")
    );
}

public record Point(int X, int Y)
{
    public Point MoveOneStep(string direction)
    {
        return direction switch
        {
            "N"  => new(X,   Y-1),
            "NE" => new(X+1, Y-1),
            "E"  => new(X+1, Y  ),
            "SE" => new(X+1, Y+1),
            "S"  => new(X,   Y+1),
            "SW" => new(X-1, Y+1),
            "W"  => new(X-1, Y  ),
            "NW" => new(X-1, Y-1),
            _ => throw new ArgumentException("Invalid direction")
        };
    }

    public string Face(Point otherPos)
    {
        char? yDir = otherPos.Y switch
        {
            var o when o < Y => 'N',
            var o when o > Y => 'S',
            _ => null,
        };

        char? xDir = otherPos.X switch
        {
            var o when o < X => 'W',
            var o when o > X => 'E',
            _ => null,
        };

        if (X == otherPos.X && Y == otherPos.Y)
            return "ARRIVED";

        if (yDir == null && xDir == null)
            throw new InvalidOperationException("Could not calculate desired direction");

        return yDir.ToString() + xDir.ToString();
    }
}

public class Thor(Point Position, string Direction)
{
    public void MoveTowards(Point light)
    {
        Direction = Position.Face(light);
        Console.WriteLine(Direction); // Output to engine
        Position = Position.MoveOneStep(Direction);
    }
}
