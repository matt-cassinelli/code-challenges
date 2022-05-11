/* -Find The Parity Outlier-
You are given an array (which will have a length of at least 3, but could be very large) containing integers.
The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
Write a method that takes the array as an argument and returns this "outlier" N.
*/

using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
namespace CodeChallenges;

public class OutlierDetector
{
    static int Solve(int[] input)
    {
        var evenNumbers = input.Where(x => x % 2 == 0);
        var oddNumbers  = input.Where(x => x % 2 == 1);
        return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
    }

    static int SolveV2(int[] input)
    {
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] % 2 == 0) {evenNumbers.Add(input[i]);}
            if (input[i] % 2 != 0) {oddNumbers.Add(input[i]);}

            if (evenNumbers.Count == 1 && oddNumbers.Count > 1) {return evenNumbers[0];}
            if (oddNumbers.Count == 1 && evenNumbers.Count > 1) {return oddNumbers[0];}
        }

        throw new ArgumentException();
    }

    [TestCase(3,         new int[] {2,6,8,-10,3} )]
    [TestCase(206847684, new int[] {206847684,1056521,7,17,1901,21104421,7,1,35521,1,7781} )]
    [TestCase(0,         new int[] { int.MaxValue, 0, 1 } )]
    [TestCase(11,        new int[] {2, 4, 0, 100, 4, 11, 2602, 36} )]
    [TestCase(160,       new int[] {160, 3, 1719, 19, 11, 13, -21} )]
    public static void Test(int expectedOutput, int[] input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}