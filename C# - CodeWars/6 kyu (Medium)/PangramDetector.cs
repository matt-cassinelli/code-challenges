/* -Detect Pangram-
A pangram is a sentence that contains every single letter of the alphabet at least once.
For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
*/

using System;
using NUnit.Framework;
namespace CodeChallenges;

public class PangramDetector
{
    static bool Solve(string input)
    {
        foreach (char letter in "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            if (!input.ToUpper().Contains(letter)) {
                return false;
            }
        }
        return true;
    }

    [TestCase(false, "Hello World!")]
    [TestCase(true, "The quick brown fox jumps over the lazy dog.")]
    public static void Test(bool expectedOutput, string input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}