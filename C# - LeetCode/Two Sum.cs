/*
Difficulty: Easy

Description:
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Constraints:
2 <= nums.length <= 104 | -109 <= nums[i] <= 109
-109 <= target   <= 109 | Only one valid answer exists.

Follow-up:
Can you come up with an algorithm that is less than O(n2) time complexity?
*/

namespace LeetCode.Task1;

public class Solution 
{
    public int[] Solve(int[] nums, int target)
    {
        for (int index1 = 0; index1 < nums.Length; index1++)
        {
            for (int index2 = 0; index2 < nums.Length; index2++)
            {
                if (index1 == index2)
                {
                    continue; // Skip current iteration
                }
                if (nums[index1] + nums[index2] == target)
                {
                    return new [] {index1, index2};
                }
            }
        }
        return null;
    }

    [Test]
    [TestCase(new [] {2,7,11,15}, 9, new [] {0,1})] // Because nums[0] + nums[1] == 9, we return [0,1].
    [TestCase(new [] {3,2,4},     6, new [] {1,2})]
    [TestCase(new [] {3,3},       6, new [] {0,1})]
    public void Test(int[] nums, int target, int[] expectedOutput)
    {
        var s = new Solution();
        s.Solve(nums, target).Should().Equal(expectedOutput);
        // Runtime: 324 ms | Memory Usage: 42.8 MB
        // Time complexity: O(n^2) | Space complexity: O(1)O(1)
    }
}