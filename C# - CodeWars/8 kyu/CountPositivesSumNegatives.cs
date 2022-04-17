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
        static int[] Solve(int[] NumberArray)
        {
            Int32 NegativeSum   = 0;
            Int32 PositiveCount = 0;

            foreach (Int32 Number in NumberArray)
            {
                if (Number < 0)
                {
                    NegativeSum += Number;
                }
                if (Number > 0)
                {
                    PositiveCount += 1;
                }
            }

            return new Int32[] {PositiveCount, NegativeSum}; // Arrays must be initialised with "new"
        }
        
        [TestCase(new[] {10, -65}, new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15})]
        [TestCase(new[] {8, -50},  new[] {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14}     )]
        //[TestCase(new int[],       null                                                          )] // Todo: Solve this.
        //[TestCase(new int[],       new int[] {}                                                  )] // Todo: Solve this.
        public void Test(int[] expected, int[] input)
        {
            Assert.AreEqual(expected, Solve(input));
        }
    }
}