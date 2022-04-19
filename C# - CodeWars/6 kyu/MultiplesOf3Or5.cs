/* -Multiples of 3 or 5-
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).
Note: If the number is a multiple of both 3 and 5, only count it once.
Courtesy of projecteuler.net
*/

using System;
using NUnit.Framework;
using System.Linq; // Needed for 2nd solution

namespace CodeChallenges
{
    public class MultiplesOf3Or5
    {
        static int Solve(int input)
        {
            int output = 0;
            for (int i = 0; i < input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    output += i;
                }
            }
            return output;
        }

        static int SolveV2(int input)
        {
            return Enumerable.Range(0, input)
                             .Where(x => x % 3 == 0 || x % 5 == 0)
                             .Sum();
        }

        [TestCase(23, 10)]
        public static void Test(int expectedOutput, int input)
        {
            Assert.AreEqual(expectedOutput, Solve(input));
        }
    }
}