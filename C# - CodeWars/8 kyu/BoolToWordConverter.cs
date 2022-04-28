/* -Convert boolean values to strings 'Yes' or 'No'-
Take a boolean value and return "Yes" for true, or "No" for false.
*/

using System;
using NUnit.Framework;
namespace CodeChallenges;

public class BoolToWordConverter
{
    private static string Solve(bool input)
    {
        switch(input)
        {
            case true:
                return "Yes";
            case false:
                return "No";
        }
    }

    [TestCase("Yes", true)]
    [TestCase("No",  false)]
    public static void Test(string expectedOutput, bool input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}