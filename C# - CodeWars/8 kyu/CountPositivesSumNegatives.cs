/* -Count of positives, sum of negatives-
Given an array of integers.
Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.
If the input is an empty array or is null, return an empty array.
Example: For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
*/

using System;
using NUnit.Framework;

namespace CodeChallenges
{
    public class Challenge
    {
        static int[] Solve(int[] input)
        {
            if (input == null || input.Length == 0) {return new int[] {};} // Handle the null scenario.

            int negativeSum   = 0;
            int positiveCount = 0;

            foreach (int number in input)
            {
                if (number < 0) {negativeSum   += number;}
                if (number > 0) {positiveCount += 1;}
            }

            return new int[] {positiveCount, negativeSum}; // Arrays must be initialised with "new"
        }
        
        [TestCase(new[] {10, -65}, new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15})]
        [TestCase(new[] {8 , -50}, new[] {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14}     )]
        [TestCase(new int[] {}   , null                                                          )]
        [TestCase(new int[] {}   , new int[] {}                                                  )]
        public void Test(int[] expectedOutput, int[] input)
        {
            Assert.AreEqual(expectedOutput, Solve(input));
        }
    }
}