/* -Reversed Strings-
Complete the solution so that it reverses the string passed into it.
'world'  =>  'dlrow'
'word'   =>  'drow'
*/

using System;
using NUnit.Framework;

namespace CodeChallenges
{
    public class StringReverser
    {
        static string Solve(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }

        [TestCase("dlrow", "world")]
        public static void Test(string expectedOutput, string input)
        {
            Assert.AreEqual(expectedOutput, Solve(input));
        }
    }
}