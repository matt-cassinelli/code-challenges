using AdventOfCode.Shared;

namespace AdventOfCode.Year2024.Day05;

public class Solution
{
    [Fact]
    public void Part1Full()
    {
        var (pageNumbers, rules) = ExtractInput();
        var total = 0;

        foreach (var pageNumberSet in pageNumbers)
        {
            if (AllRulesAreSatisfied(pageNumberSet, rules))
                total += FindMiddle(pageNumberSet);
        }

        total.Should().Be(7074);
    }

    [Theory]
    [InlineData(new[] { 75, 47, 61, 53, 29 }, true)]
    [InlineData(new[] { 97, 61, 53, 29, 13 }, true)]
    [InlineData(new[] { 75, 29, 13 }, true)]
    [InlineData(new[] { 75, 97, 47, 61, 53 }, false)]
    [InlineData(new[] { 61, 13, 29 }, false)]
    [InlineData(new[] { 97, 13, 75, 29, 47 }, false)]
    public void Part1TDD(int[] pageNumbers, bool expectedResult)
    {
        var rulesString = """
            47|53
            97|13
            97|61
            97|47
            75|29
            61|13
            75|53
            29|13
            97|29
            53|29
            61|53
            97|53
            61|29
            47|13
            75|47
            97|75
            47|61
            75|61
            47|29
            75|13
            53|13
            """;

        var rules = rulesString
            .SplitByNewline()
            .Select(Rule.FromLine)
            .ToList();

        AllRulesAreSatisfied(pageNumbers, rules)
            .Should().Be(expectedResult);
    }

    private static (List<List<int>> pageNumbers, List<Rule> rules) ExtractInput()
    {
        var pageNumbers = new List<List<int>>();
        var rules = new List<Rule>();

        foreach (var line in File.ReadAllLines("Year2024\\Day05\\input.txt"))
        {
            if (line.Contains('|'))
                rules.Add(Rule.FromLine(line));

            if (line.Contains(','))
                pageNumbers.Add(line.Split(',').Select(int.Parse).ToList());
        }

        return (pageNumbers, rules);
    }

    private static bool AllRulesAreSatisfied(IList<int> pageNumbers, IEnumerable<Rule> rules) =>
        rules.All(r => r.IsSatisfied(pageNumbers));

    private static int FindMiddle(IList<int> numbers) =>
        numbers[numbers.Count / 2];
}
