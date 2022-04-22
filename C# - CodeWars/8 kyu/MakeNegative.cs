/* -Return Negative-
In this simple assignment you are given a input and have to make it negative.
But maybe the input is already negative?
Examples:
Kata.MakeNegative(1);  // return -1
Kata.MakeNegative(-5); // return -5
Kata.MakeNegative(0);  // return 0
*/

using System;
using NUnit.Framework;

namespace CodeChallenges
{
    public class MakeNegative
    {
        static object Solve(int input)
        {
            return input > 0 ? -input : input;
        }

        static object SolveV2(int input)
        {
            switch (input)
            {
                case < 0:
                    return input;
                case > 0:
                    return input * -1;
                default:
                    return 0;
            }
        }

        static object SolveV3(int input)
        {
            return Math.Abs(input) * -1;
        }

        [TestCase(-42, 42)]
        public static void Test(int expectedOutput, int input)
        {
            Assert.AreEqual(expectedOutput, SolveV3(input));
        }
    }
}