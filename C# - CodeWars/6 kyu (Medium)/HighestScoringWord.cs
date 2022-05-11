/* -Highest Scoring Word-
Given a string of words, you need to find the highest scoring word.
Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
You need to return the highest scoring word as a string.
If two words score the same, return the word that appears earliest in the original string.
All letters will be lowercase and all inputs will be valid.
*/

using System;
using NUnit.Framework;
namespace CodeChallenges;

public class HighestScoringWord
{
	private static string alphabet = "abcdefghijklmnopqrstuvwxyz";

	public static string Solve(string input)
    {
		string[] words = input.Split(' ');
		string winningWord = "";
		int winningScore = 0;

		foreach (var word in words)
		{
			int thisScore = 0;

			foreach (var character in word)
			{
				thisScore += alphabet.IndexOf(character) + 1;
			}

			if (thisScore > winningScore)
			{
				winningScore = thisScore;
				winningWord = word;
			}
		}

        return winningWord;
    }

	[TestCase("taxi", "man i need a taxi up to ubud")]
	[TestCase("volcano", "what time are we climbing up to the volcano")]
	[TestCase("semynak", "take me to semynak")]
	[TestCase("aa", "aa b")]
	[TestCase("b", "b aa")]
	[TestCase("bb", "bb d")]
	[TestCase("d", "d bb")]
	[TestCase("aaa", "aaa b")]
    public static void Test(string expectedOutput, string input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}