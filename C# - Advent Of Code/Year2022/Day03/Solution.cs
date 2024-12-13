namespace AdventOfCode.Year2022.Day03;

public class Solution
{
    [Fact]
    public void Part1And2()
    {
        var input = File.ReadAllLines("Year2022\\Day03\\input.txt");

        // Create a rucksack for each line in input
        var rucksacks = input.Select(line => new Rucksack(line));

        var rucksackGroups = rucksacks.Chunk(3);

        var badges = new List<Item>();

        foreach (var group in rucksackGroups)
        {
            Item badge = group[0].Items
                .IntersectBy(group[1].Items.Select(i => i.Id), i => i.Id)
                .IntersectBy(group[2].Items.Select(i => i.Id), i => i.Id)
                .First();

            badges.Add(badge);
        }

        var sumOfCommonItemPriorities = rucksacks
            .Select(r => r.CommonItem.Priority)
            .Sum();

        var sumOfBadgePriorities = badges
            .Select(b => b.Priority)
            .Sum();

        sumOfCommonItemPriorities.Should().Be(7674); // Part 1
        sumOfBadgePriorities.Should().Be(2805); // Part 2
    }
}
