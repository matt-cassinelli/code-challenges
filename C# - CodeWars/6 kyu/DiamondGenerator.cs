/* -Give me a Diamond-
Jamie is a programmer, and James' girlfriend. She likes diamonds, and wants a diamond string from James. Since James doesn't know how to make this happen, he needs your help.
You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters.
Trailing spaces should be removed, and every line must be terminated with a newline character (\n).
Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.

Examples:
A size 3 diamond (" *\n***\n *\n"):
 *
***
 *

A size 5 diamond ("  *\n ***\n*****\n ***\n  *\n"):
  *
 ***
*****
 ***
  *
*/

using System;
using NUnit.Framework;
using System.Text;
namespace CodeChallenges;

public class DiamondGenerator
{
    public static string Solve(int size)
    {
        if (size % 2 == 0 || size < 1) {return null;} // Handle the special cases.
        
        var output = new string('*', size) + "\n"; // Start at the middle. "string('c', x)" repeats a character x many times

        for (int i = size - 2;   i >= 1;   i = i - 2) // Start at max, subtract 2 each time, until we reach 1.
        {
            var stringToAdd = new string(' ', (size - i) / 2) + new string('*', i) + "\n";

            output = output + stringToAdd; // Append

            output = stringToAdd + output; // Prepend
        }
        
        return output;
    }
}

[TestFixture]
public class DiamondGeneratorTests
{
	
	[Test]
	public void TestNull()
	{
		Assert.IsNull(DiamondGenerator.Solve(0));
		Assert.IsNull(DiamondGenerator.Solve(-2));
		Assert.IsNull(DiamondGenerator.Solve(2));
	}
  
    [Test]
	public void TestDiamond1()
	{
		var expected = new StringBuilder();
		expected.Append("*\n");
		Assert.AreEqual(expected.ToString(), DiamondGenerator.Solve(1));
	}
	[Test]
	public void TestDiamond3()
	{
		var expected = new StringBuilder();
		expected.Append(" *\n");
		expected.Append("***\n");
		expected.Append(" *\n");

		Assert.AreEqual(expected.ToString(), DiamondGenerator.Solve(3));
	}

	[Test]
	public void TestDiamond5()
	{
		var expected = new StringBuilder();
		expected.Append("  *\n");
		expected.Append(" ***\n");
		expected.Append("*****\n");
		expected.Append(" ***\n");
		expected.Append("  *\n");

		Assert.AreEqual(expected.ToString(), DiamondGenerator.Solve(5));
	}
}