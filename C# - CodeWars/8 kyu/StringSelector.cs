/* -Alan Partridge II - Apple Turnover-
Your job is simple, if (x) squared is more than 1000, return 'It's hotter than the sun!!', else, return 'Help yourself to a honeycomb Yorkie for the glovebox.'.
X will be either a number or a string. Both are valid.
*/

using System;
using NUnit.Framework;

namespace CodeChallenges
{
    public class StringSelector
    {
        static string Solve(object x)
        {
            return Convert.ToDouble(x) * Convert.ToDouble(x) > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
        }

        [TestCase("It's hotter than the sun!!",                            "50")]
        [TestCase("Help yourself to a honeycomb Yorkie for the glovebox.",  3  )]
        public static void Test(string expected, object input)
        {
            Assert.AreEqual(expected, Solve(input));
        }
    }
}