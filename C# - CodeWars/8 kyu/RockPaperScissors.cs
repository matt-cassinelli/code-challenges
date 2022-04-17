/* -Rock Paper Scissors-
Let's play! You have to return which player won! In case of a draw return Draw!.
Examples:
rps('scissors','paper') // Player 1 won!
rps('scissors','rock') // Player 2 won!
rps('paper','paper') // Draw!
*/

using System;
using System.Collections.Generic; // Needed for dictionary
using NUnit.Framework;

namespace CodeChallenges
{
    public class RockPaperScissors
    {
        static string Solve(string p1, string p2)
        {
            if (IsWinner(p1,p2))
            {
                return "Player 1 won!";
            }
            else if (IsWinner(p2,p1))
            {
                return "Player 2 won!";
            }
            else if (p1 == p2)
            {
                return "Draw!";
            }
            else
            {
                throw new ArgumentException();
            }
        }
        static bool IsWinner(string player, string opponent)
        {
            if ( (player == "rock" && opponent == "scissors") || (player == "scissors" && opponent == "paper") || (player == "paper" && opponent == "rock"))
            {
                return true;
            }
            else {return false;}
        }

        // Solve with Dictionary
        public string SolveV2(string p1, string p2)
        {
            return Games[Tuple.Create(p1, p2)];
        }

        private static readonly IDictionary<Tuple<string, string>, string> Games =
            new Dictionary<Tuple<string, string>, string> {
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
}