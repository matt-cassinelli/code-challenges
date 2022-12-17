using AoC.Y2022.D02;

string[] input = File.ReadAllLines("input.txt");

var you = new Player();
var opponent = new Player();

foreach (var line in input)
{
    // Part 1
    opponent.playMove(line[0]);
    you.playMove(line[2]);
    
    // Part 2
    // opponent.playMove(line[0]);
    // var outcome = new Outcome(line[2]);
    // you.playMoveToMeetOutcome(opponent.Move, outcome);

    var round = new Round(you.Move, opponent.Move);
    you.Points += round.YourPoints;
}

Console.WriteLine($"Answer: {you.Points}");