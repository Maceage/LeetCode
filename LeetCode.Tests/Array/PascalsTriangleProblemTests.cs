using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class PascalsTriangleProblemTests
{
    [Fact]
    public void Generate_TestCase_1()
    {
        // Arrange
        int numRows = 5;

        PascalsTriangleProblem pascalsTriangleProblem = new PascalsTriangleProblem();

        // Act
        IList<IList<int>> actual = pascalsTriangleProblem.Generate(numRows);

        // Assert
        int[][] expected = [[1], [1, 1], [1, 2, 1], [1, 3, 3, 1], [1, 4, 6, 4, 1]];

        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void Generate_TestCase_2()
    {
        // Arrange
        int numRows = 1;

        PascalsTriangleProblem pascalsTriangleProblem = new PascalsTriangleProblem();

        // Act
        IList<IList<int>> actual = pascalsTriangleProblem.Generate(numRows);

        // Assert
        int[][] expected = [[1]];

        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
}