namespace AoC.Y2022.D02;

class Player
{
    public int Points { get; set; }
    public Move Move { get; private set; }
    public void playMove(char inputCharacter)
    {
        switch (inputCharacter)
        {
            case 'A' or 'X':
                Move = new Rock();
                break;
            case 'B' or 'Y':
                Move = new Paper();
                break;
            case 'C' or 'Z':
                Move = new Scissors();
                break;
            default:
                throw new Exception($"Couldn't determine Move from {inputCharacter}");
        }
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