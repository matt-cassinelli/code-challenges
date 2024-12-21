namespace AdventOfCode.Shared;

public record Point(int X, int Y)
{
    public Point OneStepForwards(Direction direction)
    {
        return direction switch
        {
            Direction.Up => new(X, Y - 1),
            Direction.Down => new(X, Y + 1),
            Direction.Left => new(X - 1, Y),
            Direction.Right => new(X + 1, Y),
            _ => throw new ArgumentException("Invalid direction.")
        };
    }
};
