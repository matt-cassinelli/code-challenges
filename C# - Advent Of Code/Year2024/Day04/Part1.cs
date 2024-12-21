using AdventOfCode.Shared;

namespace AdventOfCode.Year2024.Day04;

public class Part1
{
    [Fact]
    public void SmallTests()
    {
        var input1 = """
            ..X...
            .SAMX.
            .A..A.
            XMAS.S
            .X....
            """;

        CountWordOccurence(input1).Should().Be(4);

        var input2 = """
            MMMSXXMASM
            MSAMXMSMSA
            AMXSXMAAMM
            MSAMASMSMX
            XMASAMXAMM
            XXAMMXXAMA
            SMSMSASXSS
            SAXAMASAAA
            MAMMMXMMMM
            MXMXAXMASX
            """;

        CountWordOccurence(input2).Should().Be(18);
    }

    [Fact]
    public void FullTest()
    {
        var input = File.ReadAllText("Year2024\\Day04\\input.txt");
        CountWordOccurence(input).Should().Be(2571);
    }

    // TODO: Refactor with something like https://stackoverflow.com/a/79262712
    private int CountWordOccurence(string input)
    {
        const int wordLength = 4;
        var matrix = input.ToCharMatrix();
        var height = matrix.GetLength(0);
        var width = matrix.GetLength(1);

        var occurences = 0;

        for (int yIdx = 0; yIdx < height; yIdx++)    //
        {                                            // For each point in matrix...
            for (int xIdx = 0; xIdx < width; xIdx++) //
            {
                // Horizontal
                if (xIdx < width - (wordLength-1)) // Avoid out-of-bounds
                {
                    if (matrix[yIdx, xIdx  ] == 'X' &&
                        matrix[yIdx, xIdx+1] == 'M' &&
                        matrix[yIdx, xIdx+2] == 'A' &&
                        matrix[yIdx, xIdx+3] == 'S')
                        occurences++;

                    if (matrix[yIdx, xIdx  ] == 'S' &&
                        matrix[yIdx, xIdx+1] == 'A' &&
                        matrix[yIdx, xIdx+2] == 'M' &&
                        matrix[yIdx, xIdx+3] == 'X')
                        occurences++;
                }

                // Vertical
                if (yIdx < height - (wordLength-1)) // Avoid out-of-bounds
                {
                    if (matrix[yIdx,   xIdx] == 'X' &&
                        matrix[yIdx+1, xIdx] == 'M' &&
                        matrix[yIdx+2, xIdx] == 'A' &&
                        matrix[yIdx+3, xIdx] == 'S')
                        occurences++;

                    if (matrix[yIdx,   xIdx] == 'S' &&
                        matrix[yIdx+1, xIdx] == 'A' &&
                        matrix[yIdx+2, xIdx] == 'M' &&
                        matrix[yIdx+3, xIdx] == 'X')
                        occurences++;
                }

                // Left-leaning diagonal
                if (xIdx < width  - (wordLength-1) &&
                    yIdx < height - (wordLength-1)) // Avoid out-of-bounds
                {
                    if (matrix[yIdx,   xIdx  ] == 'X' &&
                        matrix[yIdx+1, xIdx+1] == 'M' &&
                        matrix[yIdx+2, xIdx+2] == 'A' &&
                        matrix[yIdx+3, xIdx+3] == 'S')
                        occurences++;

                    if (matrix[yIdx,   xIdx  ] == 'S' &&
                        matrix[yIdx+1, xIdx+1] == 'A' &&
                        matrix[yIdx+2, xIdx+2] == 'M' &&
                        matrix[yIdx+3, xIdx+3] == 'X')
                        occurences++;
                }

                // Right-leaning diagonal
                if (xIdx >= (wordLength-1) &&
                    yIdx < height - (wordLength-1)) // Avoid out-of-bounds
                {
                    if (matrix[yIdx,   xIdx  ] == 'X' &&
                        matrix[yIdx+1, xIdx-1] == 'M' &&
                        matrix[yIdx+2, xIdx-2] == 'A' &&
                        matrix[yIdx+3, xIdx-3] == 'S')
                        occurences++;

                    if (matrix[yIdx,   xIdx  ] == 'S' &&
                        matrix[yIdx+1, xIdx-1] == 'A' &&
                        matrix[yIdx+2, xIdx-2] == 'M' &&
                        matrix[yIdx+3, xIdx-3] == 'X')
                        occurences++;
                }
            }
        }

        return occurences;
    }

    [Fact]
    [Obsolete]
    public void RowsToColumnsTests()
    {
        var input = """
            A1X
            B2Y
            C3Z
            """;

        RowsToColumns(input.SplitByNewline())[1]
            .Should().Be("123");
    }

    [Obsolete]
    private List<string> RowsToColumns(IList<string> rows)
    {
        var width = rows[0].Length;
        var height = rows.Count;
        var columns = new List<string>();

        for (var xAxisIdx = 0; xAxisIdx < width; xAxisIdx++)
        {
            var column = string.Empty;
            for (var yAxisIdx = 0; yAxisIdx < height; yAxisIdx++)
            {
                column += rows[yAxisIdx][xAxisIdx];
            }
            columns.Add(column);
        }

        return columns;
    }
}
