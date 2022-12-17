namespace AoC.Y2022.D02;

public class Round
{
    public Round(Move yourMove, Move theirMove) // Used in Part 1
    {
        if (yourMove is Rock     && theirMove is Scissors || // yourMove.GetType() == typeof(Rock)
            yourMove is Paper    && theirMove is Rock     ||
            yourMove is Scissors && theirMove is Paper    )
        {
            Outcome = new Outcome("Win");
        }

        else if (yourMove is Rock     && theirMove is Paper    ||
                 yourMove is Paper    && theirMove is Scissors ||
                 yourMove is Scissors && theirMove is Rock     )
        {
            Outcome = new Outcome("Lose");
        }

        else if (yourMove.GetType() == theirMove.GetType())
        {
            Outcome = new Outcome("Draw");
        }

        else
        {
            throw new Exception("Couldn't determine outcome");
        }

        YourPoints = Outcome.Points + yourMove.Points;
    }

    public Outcome Outcome { get; } // set allowed only in constructor
    public int YourPoints { get; }
}