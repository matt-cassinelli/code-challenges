/* -Alphabet symmetry-
Consider the word "abode". We can see that the letter a is in position 1 and b is in position 2. In the alphabet, a and b are also in positions 1 and 2.
Notice also that d and e in abode occupy the positions they would occupy in the alphabet, which are positions 4 and 5.
Given an array of words, return an array of the number of letters that occupy their positions in the alphabet for each word. For example,
solve(["abode","ABc","xyzD"]) = [4, 3, 1]
Input will consist of alphabet characters, both uppercase and lowercase. No spaces.
*/

using System;
using NUnit.Framework;
using System.Collections.Generic; // Needed for List
namespace CodeChallenges;

public class AlphabetSymmetry
{

    static List<int> Solve(List<string> input)
    {
        char[] alphabetArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        var output = new List<int>();

        foreach (string word in input)
        {
            char[] charArray = word.ToLower().ToCharArray(); // Make case-insensitive
            int matches = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == alphabetArray[i])
                {
                    matches++;
                } 
            }

            output.Add(matches);
        }

        return output;
    }

    [Test]
    public static void Test()
    {
        Assert.AreEqual( new List<int> {4, 3, 1}   , Solve( new List<string> {"abode", "ABc", "xyzD"} ));
        Assert.AreEqual( new List<int> {4, 3, 0}   , Solve( new List<string> {"abide", "ABc", "xyz"} ));
        Assert.AreEqual( new List<int> {6, 5, 7}   , Solve( new List<string> {"IAMDEFANDJKL", "thedefgh", "xyzDEFghijabc"} ));
        Assert.AreEqual( new List<int> {1, 3, 1, 3}, Solve( new List<string> {"encode", "abc", "xyzD", "ABmD"} ));
    }
}