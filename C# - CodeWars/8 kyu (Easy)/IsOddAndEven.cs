/* -Opposites Attract-
Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
*/

using System;
using NUnit.Framework;
namespace CodeChallenges;

public class IsOddAndEven
{
    static bool Solve(int flower1, int flower2)
    {
        if (IsEven(flower1) ^ IsEven(flower2))
        {return true;}
        else {return false;}
    }

    static bool IsEven(int input)
    {
        return input % 2 == 0;
    }

    [Test] public void Test()
    {
        Assert.AreEqual(true,  Solve(1,4));
        Assert.AreEqual(false, Solve(2,2));
        Assert.AreEqual(true,  Solve(0,1));
    }
}