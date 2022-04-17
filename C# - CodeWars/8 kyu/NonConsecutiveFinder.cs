/* -Find the first non-consecutive number-
Your task is to find the first element of an array that is not consecutive.
By not consecutive we mean not exactly 1 larger than the previous element of the array.
E.g. If we have an array [1,2,3,4,6,7,8] then 1 then 2 then 3 then 4 are all consecutive but 6 is not, so that's the first non-consecutive number.
If the whole array is consecutive then return null.
The array will always have at least 2 elements and all elements will be numbers. The numbers will also all be unique and in ascending order. The numbers could be positive or negative and the first non-consecutive could be either too!
*/

using System;
using NUnit.Framework;

namespace CodeChallenges
{
    public class NonConsecutiveFinder
    {
        static object Solve(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++) // We start on 1 instead of 0 to avoid index out of bounds error.
            {
                if (arr[i] != arr[i-1] + 1) {
                    return arr[i];
                }
            }

            return null;
        }

        [TestCase(6, new int[] {1, 2, 3, 4, 6, 7, 8})]
        public static void Test(int expected, int[] input)
        {
            Assert.AreEqual(expected, Solve(input));
        }
    }
}