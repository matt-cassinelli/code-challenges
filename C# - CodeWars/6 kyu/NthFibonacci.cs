/* -N-th Fibonacci-
Create a function that returns n'th element of Fibonacci sequence (classic programming task).
For reference, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
*/

using System;
using NUnit.Framework;
namespace CodeChallenges;

public class NthFibonacci
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