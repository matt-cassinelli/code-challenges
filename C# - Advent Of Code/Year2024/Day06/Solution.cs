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

    [Theory]
    [InlineData("""
    .##..
    ....#
    .....
    .^.#.
    .....
    """, 1)]
    [InlineData("""
    .#....
    .....#
    #..#..
    ..#...
    .^...#
    ....#.
    """, 3)]
    [InlineData("""
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
    """, 6)]
    public void Part2TDD(string map, int expected)
    {
        CountPossibleLoops(map).Should().Be(expected);
    }

    [Fact]
    public void Part2Full()
    {
        var map = File.ReadAllText("Year2024\\Day06\\input.txt");
        CountPossibleLoops(map).Should().Be(1836);
    }

    private static int CountVisitedPoints(string mapString)
    {
        var map = mapString.To2DCharDictionary();
        var result = Simulation.FromMap(map).Run();
        return result.VisitedPoints;
    }

    private static int CountPossibleLoops(string mapString)
    {
        var map = mapString.To2DCharDictionary();
        var keysOfEmptySpaces = map.Where(x => x.Value == '.').Select(x => x.Key);
        var loops = 0;

        foreach (var key in keysOfEmptySpaces)
        {
            var modifiedMap = new Dictionary<Point, char>(map);
            modifiedMap[key] = '#';

            if (Simulation.FromMap(modifiedMap).Run().IsLoop)
                loops++;
        }

        return loops;
    }
}
