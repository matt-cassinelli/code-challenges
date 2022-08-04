/* -You Got Change?-
In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
Create a function that will take any amount of money and break it down to the smallest number of bills as possible. Only integer amounts will be input, NO floats. This function should output a sequence, where each element in the array represents the amount of a certain bill type. The array will be set up in this manner:
array[0] ---> represents $1 bills
array[1] ---> represents $5 bills
array[2] ---> represents $10 bills
array[3] ---> represents $20 bills
array[4] ---> represents $50 bills
array[5] ---> represents $100 bills
In the case below, we broke up $365 into 1 $5 bill, 1 $10 bill, 1 $50 bill, and 3 $100 bills.
*/

using System;
using NUnit.Framework;
namespace CodeChallenges;

public class CurrencyConverter
{
    static int[] Solve(int input)
    {
        var denominations = new int[] {1, 5, 10, 20, 50, 100};
        var output = new int[6];
        var change = input;

        for (int i = denominations.Length - 1; i >= 0; i--) // Start from the last item and move towards the first.
        {
            output[i] = change / denominations[i]; // The result of this division is forced to be an integer with no decimal places.
            change    = change % denominations[i];
            //Console.WriteLine(divides + " | " + change);
        }

        return output;
    }

static int[] SolveV2(int amount)
{
    int[] result = {0,0,0,0,0,0};
    
    while(true)
    {
        while(amount >= 100){result[5] += 1; amount -= 100;}
        while(amount >= 50) {result[4] += 1; amount -= 50;}
        while(amount >= 20) {result[3] += 1; amount -= 20;}
        while(amount >= 10) {result[2] += 1; amount -= 10;}
        while(amount >= 5)  {result[1] += 1; amount -= 5;}
        while(amount >= 1)  {result[0] += 1; amount -= 1;}
        return result;
    }
}

    [TestCase(new int[] {0, 1, 1, 0, 1, 3}, 365)]
    [TestCase(new int[] {2, 1, 1, 0, 0, 2}, 217)]
    public static void Test(int[] expectedOutput, int input)
    {
        Assert.AreEqual(expectedOutput, SolveV2(input));
    }
}