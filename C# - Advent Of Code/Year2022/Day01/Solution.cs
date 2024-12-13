using AdventOfCode.Shared;

namespace AdventOfCode.Year2022.Day01;

public class Solution
{
    [Fact]
    public void Part1()
    {
        var input = File.ReadAllLines("Year2022\\Day01\\input.txt");

        var answer = GetTotals(input)
            .OrderByDescending(x => x)
            .First();

        answer.Should().Be(70369);
    }

    [Fact]
    public void Part2()
    {
        var input = File.ReadAllLines("Year2022\\Day01\\input.txt");

        var answer = GetTotals(input)
            .OrderByDescending(x => x)
            .Take(3)
            .Sum();

        answer.Should().Be(203002);
    }

    private static List<int> GetTotals(string[] input)
    {
        var output = new List<int>();
        var workingTotal = 0;

        foreach (var line in input)
        {
            if (line == string.Empty)
            {
                output.Add(workingTotal);
                workingTotal = 0;
                continue;
            }

            workingTotal += line.ToInt32();
        }

        return output;
    }
}
