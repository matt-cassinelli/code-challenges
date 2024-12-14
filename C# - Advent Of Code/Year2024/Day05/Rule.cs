namespace AdventOfCode.Year2024.Day05;

public record Rule(int Before, int After)
{
    public static Rule FromLine(string line)
    {
        var pair = line
            .Split('|')
            .Select(int.Parse)
            .ToArray();

        return new Rule(pair[0], pair[1]);
    }

    public bool IsSatisfied(IList<int> pageNumbers)
    {
        if (!pageNumbers.Contains(Before) || !pageNumbers.Contains(After))
            return true;

        if (pageNumbers.IndexOf(Before) < pageNumbers.IndexOf(After))
            return true;

        return false;
    }
}
