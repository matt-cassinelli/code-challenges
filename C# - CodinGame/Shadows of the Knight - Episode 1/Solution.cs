public static void Main(string[] args)
{
    var (searchArea, player) = ReadInitialInputs();

    while (true)
    {
        var bombDirection = Console.ReadLine(); // U, UR, R, DR, D, DL, L or UL
        searchArea = searchArea.Narrow(player, bombDirection);
        player = searchArea.Middle();
        Console.WriteLine($"{player.X} {player.Y}"); // Location of the next window to jump to
    }
}

public static (Rectangle, Point) ReadInitialInputs()
{
    string[] inputs;
    inputs = Console.ReadLine().Split(' ');

    var searchArea = Rectangle.FromWidthAndHeight(
        int.Parse(inputs[0]),
        int.Parse(inputs[1])
    );

    int turnsRemaining = int.Parse(Console.ReadLine());
    inputs = Console.ReadLine().Split(' ');
    var player = new Point(int.Parse(inputs[0]), int.Parse(inputs[1]));

    return (searchArea, player);
}


public record Point(int X, int Y);

public record Rectangle(Point TL, Point TR, Point BL, Point BR)
{
    public int LeftBoundary => TL.X;
    public int RightBoundary => TR.X;
    public int TopBoundary =>  TL.Y;
    public int BottomBoundary =>  BL.Y;

    public static Rectangle FromBoundaries(int T, int R, int B, int L) =>
        new Rectangle(
            new Point(L, T),
            new Point(R, T),
            new Point(L, B),
            new Point(R, B));

    public static Rectangle FromWidthAndHeight(int width, int height) =>
        new Rectangle(
            new Point(0,     0),
            new Point(width, 0),
            new Point(0,     height),
            new Point(width, height));

    public Point Middle() =>
        new((LeftBoundary + RightBoundary) / 2,
            (TopBoundary + BottomBoundary) / 2);

    public Rectangle Narrow(Point fromPoint, string direction)
    {
        var newTop = TopBoundary;
        var newBottom = BottomBoundary;
        var newLeft = LeftBoundary;
        var newRight = RightBoundary;

        if (direction.Contains("D"))
            newTop = fromPoint.Y; // Exclude everything above
            
        if (direction.Contains("U"))
            newBottom = fromPoint.Y; // Exclude everything below

        if (direction.Contains("L"))
            newRight = fromPoint.X; // Exclude everything to the right

        if (direction.Contains("R"))
            newLeft = fromPoint.X; // Exlude everything to the left

        return Rectangle.FromBoundaries(newTop, newRight, newBottom, newLeft);
    }
};
