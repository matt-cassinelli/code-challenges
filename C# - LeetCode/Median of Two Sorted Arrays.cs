/*
Difficulty: Hard

Description:
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
The overall run time complexity should be O(log (m+n)).

Constraints:
nums1.length == m  |  0 <= m <= 1000
nums2.length == n  |  0 <= n <= 1000
-106 <= nums1[i]   |  1 <= m + n <= 2000
nums2[i] <= 106
*/

namespace LeetCode.Task4;

public class Solution
{
    public double Solve(int[] nums1, int[] nums2)
    {
        int[] merged = Merge(nums1, nums2);
        double median = FindMedian(merged);
        return median;
    }

    double FindMedian(int[] input)
    {
        int length = input.Length;
        if (length % 2 == 0)
        {
            int midLeft = input[length / 2 - 1];
            int midRight = input[length / 2];
            return (midLeft + midRight) / 2.0; // Half-way point.
        }
        else
        {
            return input[(length - 1) / 2];
        }
    }

    int[] Merge(int[] array1, int[] array2)
    {
        var result = new int[array1.Length + array2.Length];
        int array1Index = 0, array2Index = 0, resultIndex = 0;

        while (array1Index < array1.Length && array2Index < array2.Length) // Until either array is finished...
        {
            if (array1[array1Index] < array2[array2Index]) // If array 1's number is smaller...
            {
                result[resultIndex] = array1[array1Index]; // Insert into result.
                array1Index++; // Move onto next number in array 1.
            }
            else // If array 2's number is smaller or the same...
            {
                result[resultIndex] = array2[array2Index]; // Insert into result.
                array2Index++; // Move onto next number in array 2.
            }
            resultIndex++;
        }
        while (array1Index < array1.Length) // Insert any remaining array 1 elements into result.
        {
            result[resultIndex] = array1[array1Index];
            array1Index++;
            resultIndex++;
        }
        while (array2Index < array2.Length) /// Insert any remaining array 2 elements into result.
        {
            result[resultIndex] = array2[array2Index];
            array2Index++;
            resultIndex++;
        }
        return result;
    }

    [Test]
    [TestCase(new[]{1,3  }, new[]{2    }, 2.00000)]
    [TestCase(new[]{1,2  }, new[]{3,4  }, 2.50000)]
    [TestCase(new[]{1,2  }, new[]{3,4,5}, 3.00000)]
    [TestCase(new[]{4,5,6}, new[]{1,2,3}, 3.50000)]
    public void Test(int[] input1, int[] input2, double expectedOutput)
    {
        var s = new Solution();
        s.Solve(input1, input2).Should().Be(expectedOutput);
        // Runtime: 110 ms | Memory Usage: 50.7 MB
        // Time complexity: ? | Space complexity: ?
    }
}