/* -Highest and Lowest-
In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
Examples:
Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
Notes:
All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.
*/

using System;
using NUnit.Framework;
using System.Linq; // Needed for .Select()
namespace CodeChallenges;

public class GetHighestAndLowest
{
    static string Solve(string input)
    {
        var highest = int.MinValue;
        var lowest = int.MaxValue;
        var numbers = input.Split(" ").Select(int.Parse);

        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
            
            if (number < lowest)
            {
                lowest = number;
            }
        }

        return string.Format("{0} {1}", highest, lowest);
    }

    [TestCase("42 -9", "8 3 -5 42 -1 0 0 -9 4 7 4 -4")]
    [TestCase("3 1"  , "1 2 3")]
    public static void Test(string expectedOutput, string input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}