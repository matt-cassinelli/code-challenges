/* -RGB To Hex Conversion-
Passing in RGB decimal values should result in a hexadecimal representation being returned.
Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.
Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
*/

using System;
using NUnit.Framework;
using System.Collections.Generic;
namespace CodeChallenges;

public class RgbToHexConverter
{ 
    static string Solve(int r, int g, int b)
    {
        var rHex = Clamp(r).ToString("X2");
        var gHex = Clamp(g).ToString("X2");
        var bHex = Clamp(b).ToString("X2");
        return $"{rHex}{gHex}{bHex}";
    }

    public static int Clamp(int value, int min = 0, int max = 255)
    {
        if (value < min) {return min;}
        if (value > max) {return max;}
        return value;
    }

    // TODO: Impliment at a low level instead of relying on ToString("X2")

    [TestCase("FFFFFF", 255,255,255)]
    [TestCase("FFFFFF", 255,255,300)]
    [TestCase("000000", 0,0,0)]
    [TestCase("9400D3", 148,0,211)]
    [TestCase("9400D3", 148,-20,211)]
    [TestCase("90C3D4", 144,195,212)]
    [TestCase("D4350C", 212,53,12)]
    public static void Test(string expectedOutput, int r, int g, int b)
    {
      Assert.AreEqual(expectedOutput, Solve(r,g,b));
    }
}