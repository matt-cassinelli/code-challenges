/* -Rock Paper Scissors-
Let's play! You have to return which player won! In case of a draw return "Draw!".
*/

using System;
using System.Collections.Generic; // Needed for the dictionary solution.
using NUnit.Framework;
namespace CodeChallenges;

public class RockPaperScissors
{
    static string Solve(string p1, string p2)
    {
        if      (P1Wins(p1, p2)) {return "Player 1 won!";}
        else if (P1Wins(p2, p1)) {return "Player 2 won!";}
        else if (p1 == p2) {return "Draw!";}
        else {throw new ArgumentException();}
    }

    static bool P1Wins(string p1, string p2)
    {
        if ( (p1 == "rock"     && p2 == "scissors") ||
                (p1 == "scissors" && p2 == "paper"   ) || 
                (p1 == "paper"    && p2 == "rock"    )  )
        {
            return true;
        }
        else {
            return false;
        }
    }

    public string SolveV2(string p1, string p2)
    {
        var myDictionary = new Dictionary<Tuple<string, string>, string> {
            { Tuple.Create("rock",     "rock"    ), "Draw!"         },
            { Tuple.Create("rock",     "paper"   ), "Player 2 won!" },
            { Tuple.Create("rock",     "scissors"), "Player 1 won!" },
            { Tuple.Create("paper",    "rock"    ), "Player 1 won!" },
            { Tuple.Create("paper",    "paper"   ), "Draw!"         },
            { Tuple.Create("paper",    "scissors"), "Player 2 won!" },
            { Tuple.Create("scissors", "rock"    ), "Player 2 won!" },
            { Tuple.Create("scissors", "paper"   ), "Player 1 won!" },
            { Tuple.Create("scissors", "scissors"), "Draw!"         },
        };

        return myDictionary[Tuple.Create(p1, p2)];
    }

    [Test] public void Test()
    {
        Assert.AreEqual("Player 1 won!", Solve("rock", "scissors"));
        Assert.AreEqual("Player 1 won!", Solve("scissors", "paper"));
        Assert.AreEqual("Player 1 won!", Solve("paper", "rock"));
        Assert.AreEqual("Player 2 won!", Solve("scissors", "rock"));
        Assert.AreEqual("Player 2 won!", Solve("paper", "scissors"));
        Assert.AreEqual("Player 2 won!", Solve("rock", "paper"));
        Assert.AreEqual("Draw!",         Solve("rock", "rock"));
        Assert.AreEqual("Draw!",         Solve("scissors", "scissors"));
        Assert.AreEqual("Draw!",         Solve("paper", "paper"));
    }
}