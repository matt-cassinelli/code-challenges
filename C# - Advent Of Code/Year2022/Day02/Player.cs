namespace AdventOfCode.Year2022.Day02;

class Player
{
    public int Points { get; set; }
    public Move Move { get; private set; }
    public void playMove(char inputCharacter)
    {
        Move = inputCharacter switch
        {
            'A' or 'X' => new Rock(),
            'B' or 'Y' => new Paper(),
            'C' or 'Z' => new Scissors(),
            _ => throw new Exception($"Couldn't determine Move from {inputCharacter}"),
        };
    }

    public void playMoveToMeetOutcome(Move opponentMove, Outcome outcome)
    {
        if (outcome.Name == "Win"  && opponentMove is Rock ||
            outcome.Name == "Draw" && opponentMove is Paper ||
            outcome.Name == "Lose" && opponentMove is Scissors )
        {
            Move = new Paper();
        }
        else if (outcome.Name == "Win"  && opponentMove is Paper ||
                 outcome.Name == "Draw" && opponentMove is Scissors ||
                 outcome.Name == "Lose" && opponentMove is Rock )
        {
            Move = new Scissors();
        }
        else if (outcome.Name == "Win"  && opponentMove is Scissors ||
                 outcome.Name == "Draw" && opponentMove is Rock ||
                 outcome.Name == "Lose" && opponentMove is Paper )
        {
            Move = new Rock();
        }
        else {
            throw new Exception($"Couldn't find a move that meets outcome {outcome.Name}");
        }
    }
}