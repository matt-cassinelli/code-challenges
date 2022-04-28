/* -Reduce but Grow-
Given a non-empty array of integers, return the result of multiplying the values together.
Example: [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
*/

using System;
using NUnit.Framework;
namespace CodeWars;

public class Multiplier
{
    static int Solve(int[] input)
    {
        int output = 1;

        for (int i = 0; i < input.Length; i++)
        {
            output = input[i] * output;
        }

        return output;
    }

    [TestCase(6, new[] { 1, 2, 3 })]
    [TestCase(16, new [] { 4, 1, 1, 1, 4 })]
    [TestCase(64, new [] { 2, 2, 2, 2, 2, 2 })]
    public void Test(int expectedOutput, int[] input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}