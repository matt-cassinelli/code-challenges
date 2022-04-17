/* -Reduce but Grow-
Given a non-empty array of integers, return the result of multiplying the values together in order.
Example: [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
*/

using System;
using NUnit.Framework;

namespace CodeWars
{
    public class Multiplier
    {
        static int[] Solve(int[] NumberArray)
        {
            for (int i = 0; i < NumberArray.Length; i++)
            {
                NumberArray[i] = NumberArray[i] * 2;
            }

            return NumberArray;
        }

        [TestCase(new[] { 2, 4, 6 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 8, 2, 2, 2, 8 }, new[] { 4, 1, 1, 1, 4 })]
        [TestCase(new[] { 4, 4, 4, 4, 4, 4 }, new[] { 2, 2, 2, 2, 2, 2 })]
        public void Test(int[] expected, int[] input)
        {
            Assert.AreEqual(expected, Solve(input));
        }
    }
}