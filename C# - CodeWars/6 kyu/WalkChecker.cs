/* -Take a Ten Minutes Walk-
You live in the city of Cartesia where all roads are laid out in a perfect grid.
You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk.
The city provides its citizens with a Walk Generating App on their phones --
everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']).
You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block,
so create a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.
Note: you will always receive a valid array containing a random assortment of direction letters ('n', 's', 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).
*/

using System;
using NUnit.Framework;
namespace CodeChallenges;

public class WalkChecker
{
    static bool Solve(string[] input)
    {
        int x = 0;
        int y = 0;

        foreach (var direction in input)
        {
            switch (direction)
            {
                case "n": y++; break;
                case "e": x++; break;
                case "s": y--; break;
                case "w": x--; break;
            }
        }

        //Console.WriteLine(input.Length); // Walk duration
        //Console.WriteLine(x + ", " + y));

        if (input.Length == 10 && x == 0 && y == 0) {return true;}
        else {return false;}
    }
    
    [TestCase(true , new[] {"n","s","n","s","n","s","n","s","n","s"})]
    [TestCase(false, new[] {"w","e","w","e","w","e","w","e","w","e","w","e"})]
    [TestCase(false, new[] {"w"})]
    [TestCase(false, new[] {"n","n","n","s","n","s","n","s","n","s"})]
    public void Test(bool expectedOutput, string[] input)
    {
        Assert.AreEqual(expectedOutput, Solve(input));
    }
}