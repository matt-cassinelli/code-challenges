using AdventOfCode.Shared;

namespace AdventOfCode.Year2024.Day01;

public class Solution
{
    [Fact]
    public void Part1()
    {
        var (leftList, rightList) = GetLists();
        leftList.Sort();
        rightList.Sort();

        var difference = 0;
        for (int i = 0; i < leftList.Count; i++)
        {
            difference += Utils.FindDifference(leftList[i], rightList[i]);
        }

        difference.Should().Be(1506483);
    }

    [Fact]
    public void Part2()
    {
        var (left, right) = GetLists();
        var common = left.Intersect(right);

        var similarityScore = 0;
        foreach (var number in left)
        {
            var count = right.Where(x => x == number).Count();
            similarityScore += number * count;
        }

        similarityScore.Should().Be(23126924);
    }

    private static (List<int>, List<int>) GetLists()
    {
        var input = File.ReadAllLines("Year2024\\Day01\\input.txt");

        var leftList = new List<int>();
        var rightList = new List<int>();

        foreach (var line in input)
        {
            var lists = line.Split("   ");
            leftList.Add(lists[0].ToInt32());
            rightList.Add(lists[1].ToInt32());
        }

        return (leftList, rightList);
    }
}
