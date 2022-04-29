/* -Roman Numerals Decoder-
Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.
You don't need to validate the form of the Roman numeral.
Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s.
So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII).
The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.
Example:
RomanDecode.Solution("XXI") -- should return 21
Help:
Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000
*/

using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic; // Needed for dictionary
namespace CodeChallenges;

public class RomanNumeralDecoder
{
    static int Solve(string input)
    {
        int output = 0;

        var numerals = new Dictionary<char, int>
        {
            { 'I', 1    },
            { 'V', 5    },
            { 'X', 10   },
            { 'L', 50   },
            { 'C', 100  },
            { 'D', 500  },
            { 'M', 1000 }
        };

        foreach (var letter in input)
        {
            output += numerals[letter];
        }

        if (input.Contains("IV")|| input.Contains("IX"))
            output -= 2;

        if (input.Contains("XL")|| input.Contains("XC"))
            output -= 20;

        if (input.Contains("CD")|| input.Contains("CM"))
            output -= 200;

        return output;
    }

    [TestCase(21  , "XXI")]
    [TestCase(1   , "I")]
    [TestCase(2   ,"II")]
    [TestCase(4   ,"IV")]
    [TestCase(21  ,"XXI")]
    [TestCase(500 ,"D")]
    [TestCase(1000,"M")]
    [TestCase(1954,"MCMLIV")]
    [TestCase(1990,"MCMXC")]
    [TestCase(2008,"MMVIII")]
    [TestCase(2014,"MMXIV")]
    public static void Test(int expectedOutput, string input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}