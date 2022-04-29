/* -Sort Numbers-
Finish the solution so that it sorts the passed in array of numbers.
If the function passes in an empty array or null then it should return an empty array.
*/

using System;
using NUnit.Framework;
using System.Collections;
namespace CodeChallenges;

public class NumberSorter
{
    static int[] BubbleSort(int[] input) // Complexity: n^2
    {
        if (input == null) {return new int[] {};} // Needed to handle the null scenario.
        var output = input;
        bool loopAgain = true;

        while (loopAgain == true)
        {
            loopAgain = false; // Priming.

            for (int i = 0; i < input.Length - 1; i++) // Since we are looking ahead in the array, "- 1" is needed to avoid an out of bounds error.
            {
                if (output[i] > output[i+1])
                {
                    var temp = output[i];    //
                    output[i] = output[i+1]; // Swap
                    output[i+1] = temp;      //
                    loopAgain = true;
                }
                //Console.WriteLine("[{0}]", string.Join(", ", output)); // Hack to print array to console.
            }
            // If we reach this point and loopAgain is false, then the numbers are in order.
        }
        return output;
    }

    static int[] MergeSort(int[] input) // TODO. Complexity: nlogn
    {
        var output = input;
        return output;
    }

    static int[] InsertionSort(int[] input) // TODO.
    {
        var output = input;
        return output;
    }

    static int[] HeapSort(int[] input) // TODO.
    {
        var output = input;
        return output;
    }

    static int[] QuickSort(int[] input) // TODO.
    {
        var output = input;
        return output;
    }

    static int[] CountingSort(int[] input) // TODO.
    {
        var output = input;
        return output;
    }

    static int[] RadixSort(int[] input) // TODO.
    {
        var output = input;
        return output;
    }

    static int[] BucketSort(int[] input) // TODO.
    {
        var output = input;
        return output;
    }

    static int[] CombSort(int[] input) // TODO.
    {
        var output = input;
        return output;
    }

    static int[] ShellSort(int[] input) // TODO.
    {
        var output = input;
        return output;
    }

    static int[] BuiltInSort(int[] input)
    {
        if(input == null)
        input = new int[0];

        Array.Sort(input);
        return input;
    }

    [TestCase(new int[] { 1, 2, 3, 5, 10 }, new int[] { 1, 2, 3, 10, 5 })]
    [TestCase(new int[] { 2, 10, 20 }     , new int[] { 20, 2, 10 })]
    [TestCase(new int[] { 2, 10, 20 }     , new int[] { 2, 20, 10 })]
    [TestCase(new int[] { 2, 10, 20 }     , new int[] { 2, 10, 20 })]
    [TestCase(new int[] { }               , new int[] { })]
    [TestCase(new int[] { }               , null)]
    public static void Test(int[] expectedOutput, int[] input)
    {
        Assert.AreEqual(expectedOutput, BubbleSort(input));
    }

}