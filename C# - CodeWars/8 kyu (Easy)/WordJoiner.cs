/* -Sentence Smash-
Write a function that takes an array of words and smashes them together into a sentence and returns the sentence.
You can ignore any need to sanitize words or add punctuation, but you should add spaces between each word.
Be careful, there shouldn't be a space at the beginning or the end of the sentence! */

using System;
using NUnit.Framework;
namespace CodeChallenges;

public class WordJoiner
{
    static string Solve(string[] words)
    {
        String sentence = "";

        for (int i = 0; i < words.Length; i++)
        {
            if(i == 0) // First word
            {
                sentence = words[i];
            }
            else // Subsequent words.
            {
                sentence = sentence + " " + words[i];
            }
        }
        
        return sentence;
    }

    static string SolveV2(string[] words) {
        return String.Join(" ", words);
    }
    
    [TestCase("hello",                           new string[] {"hello"})]
    [TestCase("hello world",                     new string[] {"hello", "world"})]
    [TestCase("hello amazing world",             new string[] {"hello", "amazing", "world"})]
    [TestCase("",                                new string[] {""})]
    public void Test(string expectedOutput, string[] input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}