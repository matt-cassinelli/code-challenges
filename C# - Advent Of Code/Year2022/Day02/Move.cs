namespace AdventOfCode.Year2022.Day02;

public abstract class Move
{
    public abstract int Points { get; }
}

public class Rock : Move
{
    public override int Points { get => 1; }
}

public class Paper : Move
{
    public override int Points { get => 2; }
}

public class Scissors : Move
{
    public override int Points { get => 3; }
}
