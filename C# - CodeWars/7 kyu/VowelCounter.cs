/* -Vowel Count-
Return the number (count) of vowels in the given string.
We will consider a, e, i, o, u as vowels for this Kata (but not y).
The input string will only consist of lower case letters and/or spaces.
*/

using System;
using NUnit.Framework;
using System.Linq; // needed for .Contains()
using System.Text.RegularExpressions; // needed for 2nd solution

namespace CodeChallenges
{
    public class VowelCounter
    {
        static int Solve(string str)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            int vowelCount = 0;

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

        static int SolveV2(string str)
        {
            return (Regex.Matches(str, @"[aeiouAEIOU]")).Count;
        }

        [TestCase(5, "abracadabra")]
        public static void Test(int expectedOutput, string input)
        {
            Assert.AreEqual(expectedOutput, Solve(input));
        }
    }
}