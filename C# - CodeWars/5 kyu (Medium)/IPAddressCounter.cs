/* -Count IP Addresses-
Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).
All inputs will be valid IPv4 addresses in the form of strings.
The last address will always be greater than the first one.

Examples:
* With input "10.0.0.0", "10.0.0.50"  => return   50 
* With input "10.0.0.0", "10.0.1.0"   => return  256 
* With input "20.0.0.10", "20.0.1.0"  => return  246
*/

using System;
using NUnit.Framework;
using System.Linq; // Needed for .Select()
namespace CodeChallenges;

public class IPAddressCounter
{
    static long Solve(string input1, string input2)
    {
        long number1 = IPAddressToNumber(input1);
        long number2 = IPAddressToNumber(input2);

        return number2 - number1;
    }

    static long IPAddressToNumber(string input)
    {
        int[] myArray = input.Split('.').Select(x => Convert.ToInt32(x)).ToArray(); // Convert the string to an array of ints.
        // Console.WriteLine("[{0}]", string.Join(", ", myArray)); // (hack to print array to console)

        double output =
            myArray[0] * Math.Pow(256,3) +
            myArray[1] * Math.Pow(256,2) +
            myArray[2] * Math.Pow(256,1) +
            myArray[3];

        return Convert.ToInt64(output); // This conversion is needed because Math.Pow() returns a "double", but we need a "long"
    }

    [TestCase(50        , "10.0.0.0" , "10.0.0.50"      )]
    [TestCase(246       , "20.0.0.10", "20.0.1.0"       )]
    [TestCase(4294967295, "0.0.0.0"  , "255.255.255.255")]
    
    public static void Test(long expectedOutput, string input1, string input2)
    {
        Assert.AreEqual(expectedOutput, Solve(input1, input2));
    }
}