/*
Difficulty: Medium

Description:
You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
Find two lines that together with the x-axis form a container, such that the container contains the most water.
Return the maximum amount of water a container can store.
Notice that you may not slant the container.

Example 1:
https://s3-lc-upload.s3.amazonaws.com/uploads/2018/07/17/question_11.jpg
Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

Example 2:
Input: height = [1,1]
Output: 1

Constraints:
n == height.length
2 <= n <= 105
0 <= height[i] <= 104
*/

namespace LeetCode.Task11;

public class Solution 
{
    public int Solve(int[] input)
    {
        int winningArea = 0;
        for (int leftIndex = 0; leftIndex < input.Length; leftIndex++)
        {
            for (int rightIndex = leftIndex+1; rightIndex < input.Length; rightIndex++)
            {
                int commonHeight = Math.Min(input[leftIndex], input[rightIndex]);
                int distanceBetween = rightIndex - leftIndex;
                int area = commonHeight * distanceBetween;
                if (area > winningArea) {winningArea = area;}
            }
        }
        return winningArea;
    }

    public int SolveV2(int[] input)
    {
        int winningArea = 0;
        int leftIndex = 0;
        int rightIndex = input.Length - 1;
        
        while (rightIndex > leftIndex) // Break when walls have closed in.
        {
            int commonHeight = Math.Min(input[leftIndex], input[rightIndex]);
            int distanceBetween = rightIndex - leftIndex;
            int area = commonHeight * distanceBetween;
            winningArea = Math.Max(winningArea, area); // Update max area if larger.
            
            if (input[rightIndex] > input[leftIndex]) // If right wall is taller...
            {
                leftIndex++; // Move left wall inwards.
            }
            else // If left wall is taller, or the same...
            {
                rightIndex--; // Move right wall inwards.
            }
        }
        return winningArea;
    }

    [Test]
    [TestCase(new [] {1,8,6,2,5,4,8,3,7}, 49)]
    [TestCase(new [] {1,1              }, 1 )]
    public void Test(int[] input, int expectedOutput)
    {
        var s = new Solution();
        
        //s.Solve(input).Should().Be(expectedOutput);
        // Time complexity: O(n^2). Calculating area for all \dfrac{n(n-1)}{2} height pairs.
        // Space complexity: O(1)O(1). Constant extra space is used.

        s.SolveV2(input).Should().Be(expectedOutput);
        // Runtime: 363 ms | Memory Usage: 46.3 MB
        //Time complexity: O(n)O(n). Single pass.
        //Space complexity: O(1)O(1). Constant space is used.
    }
}