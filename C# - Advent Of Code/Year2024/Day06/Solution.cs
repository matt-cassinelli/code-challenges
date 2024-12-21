using AdventOfCode.Shared;

namespace AdventOfCode.Year2024.Day06;

public class Solution
{
    [Fact]
    public void Part1TDD()
    {
        var map = """
        ....#.....
        .........#
        ..........
        ..#.......
        .......#..
        ..........
        .#..^.....
        ........#.
        #.........
        ......#...
        """;

        CountVisitedPoints(map).Should().Be(41);
    }

    [Fact]
    public void Part1Full()
    {
        var map = File.ReadAllText("Year2024\\Day06\\input.txt");
        CountVisitedPoints(map).Should().Be(5461);
    }

    public static int CountVisitedPoints(string mapString)
    {
        var (player, map) = ExtractInput(mapString);
        var visitedPoints = new HashSet<Point>();

        bool PlayerIsLookingAtObstacle() => map[player.LookingAt()] == '#';
        bool PlayerIsLookingAtMapEdge() => !map.ContainsKey(player.LookingAt());

        while (true)
        {
            if (!visitedPoints.Contains(player.Position))
                visitedPoints.Add(player.Position);

            if (PlayerIsLookingAtMapEdge())
                break;

            if (PlayerIsLookingAtObstacle())
                player.Rotate90();

            player.MoveOneStep();
        }

        return visitedPoints.Count;
    }

    public static (Player, Dictionary<Point, char>) ExtractInput(string str)
    {
        var array = str
            .SplitByNewline()
            .Select(line => line.ToArray())
            .ToArray();

        Player? player = null;

        var map = new Dictionary<Point, char>();

        for (int y = 0; y < array.Length; y++)
        {
            for (int x = 0; x < array[0].Length; x++)
            {
                map.Add(new(x, y), array[y][x]);

                if (array[y][x] == '^')
                    player = new Player(x, y);
            }
        }

        if (player == null)
            throw new ArgumentException("Player is missing from input.");

        return (player, map);
    }
}

