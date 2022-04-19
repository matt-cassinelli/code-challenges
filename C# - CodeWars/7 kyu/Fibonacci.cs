/* -Fibonacci-
Create function fib that returns n'th element of Fibonacci sequence (classic programming task).
*/

using System;
using NUnit.Framework;

namespace CodeChallenges
{
    public class Fibonacci
    {
        static int Solve(int n)
        {
            int prev    = 0;
            int current = 1;

            for (int i = 0; i < n; i++)
            {
                // Console.WriteLine(current);
                int temp = prev;
                prev = current;
                current = prev + temp;
            }

            return prev;
        }

        [TestCase(5 , 5)]
        [TestCase(55, 10)]
        public static void Test(int expectedOutput, int input)
        {
            Assert.AreEqual(expectedOutput, Solve(input));
        }
    }
}