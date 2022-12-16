namespace AoC.Y2022;

class Program
{
    static void Main(string[] args)
    {
        string[] input = File.ReadAllLines("input.txt");

        var totals = GetTotals(input);

        int highest = totals.OrderByDescending(x => x).First();
        Console.WriteLine($"Solution for Part 1: {highest}");

        var topThree = totals.OrderByDescending(x => x).Take(3).Sum();
        Console.WriteLine($"Solution for Part 2: {topThree}");
    }

    static List<int> GetTotals(string[] input)
    {
        var output = new List<int>();
        var workingTotal = 0;
        
        foreach (var line in input)
        {
            if (line == string.Empty)
            {
                output.Add(workingTotal);
                workingTotal = 0;
            }
            else
            {
                workingTotal += Int32.Parse(line);
            }
        }
        return output;
    }
}