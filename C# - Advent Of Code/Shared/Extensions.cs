using System.Globalization;

namespace AdventOfCode.Shared;

public static class Extensions
{
    public static int ToInt32(this string input)
    {
        return int.Parse(
            input,
            NumberStyles.Integer,
            CultureInfo.InvariantCulture.NumberFormat);
    }

    public static IList<string> SplitByNewline(this string input)
    {
        string[] delimeters = ["\n", "\r", "\r\n"];
        return input.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
    }

    public static char[,] ToCharMatrix(this string input)
    {
        var lines = input.SplitByNewline();
        var height = lines.Count;
        int width = lines[0].Length;

        char[,] matrix = new char[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                matrix[i, j] = lines[i][j];
            }
        }

        return matrix;
    }

    public static Dictionary<Point, char> To2DCharDictionary(this string input)
    {
        var array = input
            .SplitByNewline()
            .Select(line => line.ToArray())
            .ToArray();

        Dictionary<Point, char> map = [];

        for (int y = 0; y < array.Length; y++)
        {
            for (int x = 0; x < array[0].Length; x++)
            {
                map.Add(new(x, y), array[y][x]);
            }
        }

        return map;
    }
}
