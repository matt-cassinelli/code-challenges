/*
Difficulty: Easy

Link: https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

Description:
Given an integer num, return the number of steps to reduce it to zero.
In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.

Constraints:
0 <= num <= 106
*/

public class Solution {

    public int Solve(int input)
    {
        int stepCount = 0;

        while (input > 0)
        {
            if (input % 2 == 0) {input = input / 2;}
            else {input = input - 1;}
            stepCount++;
        }
        return stepCount;
    }

    [Test]
    [TestCase(14, 6)]
    [TestCase(8, 4)]
    [TestCase(123, 12)]
    public void Test(int input, int expectedOutput)
    {
        var s = new Solution();
        s.Solve(input).Should().Be(expectedOutput);
        // Time complexity:
        // Space complexity:
    }
}