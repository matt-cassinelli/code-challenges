/* -Return Negative-
In this simple assignment you are given a number and have to make it negative.
But maybe the number is already negative?
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
        static object Solve(int number)
        {
            switch (number)
            {
                case < 0:
                    return number;
                case > 0:
                    return number * -1;
                default:
                    return 0;
            }
        }

        static object SolveV2(int number)
        {
            return -Math.Abs(number);
        }

        static object SolveV3(int number)
        {
            return number > 0 ? -number : number;
        }

        [TestCase(-42, 42)]
        public static void Test(int expected, int input)
        {
            Assert.AreEqual(expected, Solve(input));
        }
    }
}