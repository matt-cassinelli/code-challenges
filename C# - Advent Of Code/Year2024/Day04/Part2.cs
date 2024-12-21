using AdventOfCode.Shared;

namespace AdventOfCode.Year2024.Day04;

public class Part2
{
    [Fact]
    public void SmallTests()
    {
        var input1 = """
            M.S
            .A.
            M.S
            """;

        CountWordOccurence(input1).Should().Be(1);

        var input2 = """
            .M.S......
            ..A..MSMS.
            .M.S.MAA..
            ..A.ASMSM.
            .M.S.M....
            ..........
            S.S.S.S.S.
            .A.A.A.A..
            M.M.M.M.M.
            ..........
            """;

        CountWordOccurence(input2).Should().Be(9);
    }

    [Fact]
    public void FullTest()
    {
        var input = File.ReadAllText("Year2024\\Day04\\input.txt");
        CountWordOccurence(input).Should().Be(1992);
    }

    private int CountWordOccurence(string input)
    {
        var matrix = input.ToCharMatrix();
        var height = matrix.GetLength(0);
        var width = matrix.GetLength(1);

        var occurences = 0;

        for (int yIdx = 1; yIdx < height-1; yIdx++)    //
        {                                              // For each point in matrix (exluding borders)...
            for (int xIdx = 1; xIdx < width-1; xIdx++) //
            {
                if ( 
                     (
                       (matrix[yIdx-1, xIdx-1] == 'M' &&
                        matrix[yIdx  , xIdx  ] == 'A' &&
                        matrix[yIdx+1, xIdx+1] == 'S')
                       ||
                       (matrix[yIdx-1, xIdx-1] == 'S' &&
                        matrix[yIdx  , xIdx  ] == 'A' &&
                        matrix[yIdx+1, xIdx+1] == 'M')
                     )
                     &&
                     (
                       (matrix[yIdx-1, xIdx+1] == 'M' &&
                        matrix[yIdx  , xIdx  ] == 'A' &&
                        matrix[yIdx+1, xIdx-1] == 'S')
                       ||
                       (matrix[yIdx-1, xIdx+1] == 'S' &&
                        matrix[yIdx  , xIdx  ] == 'A' &&
                        matrix[yIdx+1, xIdx-1] == 'M')
                     )
                   )
                {
                    occurences++;
                }
            }
        }

        return occurences;
    }
}
