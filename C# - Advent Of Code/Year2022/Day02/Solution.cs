namespace AdventOfCode.Year2022.Day02;

public class Solution
{
    [Fact]
    public void Part1()
    {
        var input = File.ReadAllLines("Year2022\\Day02\\input.txt");
        var you = new Player();
        var opponent = new Player();

        foreach (var line in input)
        {
            opponent.playMove(line[0]);
            you.playMove(line[2]);

            var round = new Round(you.Move, opponent.Move);
            you.Points += round.YourPoints;
        }

        you.Points.Should().Be(10718);
    }

    [Fact]
    public void Part2()
    {
        var input = File.ReadAllLines("Year2022\\Day02\\input.txt");
        var you = new Player();
        var opponent = new Player();

        foreach (var line in input)
        {
            opponent.playMove(line[0]);
            var outcome = new Outcome(line[2]);
            you.playMoveToMeetOutcome(opponent.Move, outcome);

            var round = new Round(you.Move, opponent.Move);
            you.Points += round.YourPoints;
        }

        you.Points.Should().Be(14652);
    }
}
