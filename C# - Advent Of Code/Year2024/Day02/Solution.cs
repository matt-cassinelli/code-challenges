using AdventOfCode.Shared;

namespace AdventOfCode.Year2024.Day02;

public class Solution
{
    [Theory]
    [InlineData("7 6 4 2 1", true)]
    [InlineData("1 2 7 8 9", false)]
    [InlineData("9 7 6 2 1", false)]
    [InlineData("1 3 2 4 5", false)]
    [InlineData("8 6 4 4 1", false)]
    [InlineData("1 3 6 7 9", true)]
    public void Part1TDD(string report, bool isSafe)
    {
        ReportIsSafe(report).Should().Be(isSafe);
    }

    [Fact]
    public void Part1Full()
    {
        var reports = File.ReadAllLines("Year2024\\Day02\\input.txt");

        reports
            .Where(ReportIsSafe)
            .Count()
            .Should().Be(218);
    }

    [Theory (Skip = "Not implemented yet")]
    [InlineData("7 6 4 2 1", true)]
    [InlineData("1 2 7 8 9", false)]
    [InlineData("9 7 6 2 1", false)]
    [InlineData("1 3 2 4 5", true)]
    [InlineData("8 6 4 4 1", true)]
    [InlineData("1 3 6 7 9", true)]
    public void Part2TDD(string report, bool isSafe)
    {
        //ReportIsSafeWithDampener(report).Should().Be(isSafe);
    }

    private bool ReportIsSafe(string reportString)
    {
        var report = reportString
            .Split(' ')
            .Select(Int32.Parse)
            .ToList();

        var ascending = report.OrderBy(x => x).ToList();
        var descending = report.OrderByDescending(x => x).ToList();

        if (!Enumerable.SequenceEqual(report, ascending) &&
            !Enumerable.SequenceEqual(report, descending))
        {
            return false;
        }
            
        for (int i = 1; i < report.Count; i++)
        {
            var difference = Utils.FindDifference(report[i], report[i - 1]);

            if (difference < 1 || difference > 3)
                return false;
        }

        return true;
    }
}
