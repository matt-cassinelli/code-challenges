using AdventOfCode.Shared;
using System.Text.RegularExpressions;

namespace AdventOfCode.Year2024.Day03;

public class Solution
{
    [Theory]
    [InlineData("mul(44,46)", 2024)]
    [InlineData("mul(123,4)", 492)]
    [InlineData("mul(4*", 0)]
    [InlineData("mul(6,9!", 0)]
    [InlineData("?(12,34)", 0)]
    [InlineData("mul ( 2 , 4 )", 0)]
    [InlineData("xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))", 161)]
    public void Part1TDD(string instructions, int expectedResult)
    {
        EvaluateInstructionLine(instructions)
            .Should().Be(expectedResult);
    }

    [Fact]
    public void Part1Full()
    {
        var input = File.ReadAllLines("Year2024\\Day03\\input.txt");

        var total = 0;
        foreach (var line in input)
        {
            total += EvaluateInstructionLine(line);
        }

        total.Should().Be(169021493);
    }

    [Fact (Skip = "Not implemented yet")]
    public void Part2TDD()
    {
        EvaluateInstructionLine("xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))")
            .Should().Be(48);
    }

    private int EvaluateInstructionLine(string instructions)
    {
        var matches = Regex.Matches(instructions, @"mul\(\d+,\d+\)");

        var total = 0;
        foreach (Match match in matches)
        {
            total += EvaluateMulInstruction(match.Value);
        }

        return total;
    }

    private int EvaluateMulInstruction(string mulInstruction)
    {
        var leftNum = mulInstruction
            .Substring(0, mulInstruction.IndexOf(','))
            .Substring(4)
            .ToInt32();

        var rightNum = mulInstruction
            .Substring(mulInstruction.IndexOf(',') + 1)
            .TrimEnd(')')
            .ToInt32();

        return leftNum * rightNum;
    }
}
