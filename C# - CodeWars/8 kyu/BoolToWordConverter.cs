/* -Convert boolean values to strings 'Yes' or 'No'-
Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
*/

using System;
using NUnit.Framework;

namespace CodeChallenges
{
    public class BoolToWordConverter
    {
        private static string Solve(bool input)
        {
            switch(input)
            {
                case true:
                    return "Yes";
                case false:
                    return "No";
            }
        }

        [TestCase("Yes", true)]
        [TestCase("No",  false)]
        public static void Test(string expectedOutput, bool input)
        {
            Assert.AreEqual(expectedOutput, Solve(input));
        }
    }
}