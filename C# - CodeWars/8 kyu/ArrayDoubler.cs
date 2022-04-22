/* -Lost Without a Map-
Given an array of integers, return a new array with each value doubled. For example:
[1, 2, 3] --> [2, 4, 6]
*/

using System;
using NUnit.Framework;

namespace CodeChallenges
{
    public class ArrayDoubler
    {
        static int[] Solve(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * 2;
            }

            return input;
        }

        [TestCase(new [] { 2, 4, 6 },           new [] { 1, 2, 3 })]
        [TestCase(new [] { 8, 2, 2, 2, 8 },     new [] { 4, 1, 1, 1, 4 })]
        [TestCase(new [] { 4, 4, 4, 4, 4, 4 },  new [] { 2, 2, 2, 2, 2, 2 })]
        public static void Test(int[] expectedOutput, int[] input)
        {
            Assert.AreEqual(expectedOutput, Solve(input));
        }

    }
}