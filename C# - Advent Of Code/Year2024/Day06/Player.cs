using AdventOfCode.Shared;

namespace AdventOfCode.Year2024.Day06;

public class Player
{
    public Player(int x, int y)
    {
        Position = new Point(x, y);
        Direction = Direction.Up;
    }

    public Player(Dictionary<Point, char> map)
    {
        var test = map.FirstOrDefault(x => x.Value == '^');
        Position = test.Key;
        Direction = Direction.Up;
    }

    public Point Position { get; private set; }
    public Direction Direction { get; private set; }

    public void Rotate90()
    {
        Direction = Direction switch
        {
            Direction.Up => Direction.Right,
            Direction.Right => Direction.Down,
            Direction.Down => Direction.Left,
            Direction.Left => Direction.Up,
            _ => throw new InvalidOperationException("Invalid Direction")
        };
    }

    public void MoveOneStep()
    {
        Position = Position.OneStepForwards(Direction);
    }

    public Point LookingAt()
    {
        return Position.OneStepForwards(Direction);
    }
}
