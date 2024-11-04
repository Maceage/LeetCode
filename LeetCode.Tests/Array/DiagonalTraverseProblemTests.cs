using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class DiagonalTraverseProblemTests
{
    [Fact]
    public void FindDiagonalOrder_TestCase_1()
    {
        // Arrange
        int[][] mat = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

        DiagonalTraverseProblem diagonalTraverseProblem = new DiagonalTraverseProblem();

        // Act
        int[] actual = diagonalTraverseProblem.FindDiagonalOrder(mat);

        // Assert
        actual.Should().BeEquivalentTo([1, 2, 4, 7, 5, 3, 6, 8, 9]);
    }

    [Fact]
    public void FindDiagonalOrder_TestCase_2()
    {
        // Arrange
        int[][] mat = [[1, 2], [3, 4]];

        DiagonalTraverseProblem diagonalTraverseProblem = new DiagonalTraverseProblem();

        // Act
        int[] actual = diagonalTraverseProblem.FindDiagonalOrder(mat);

        // Assert
        actual.Should().BeEquivalentTo([1, 2, 3, 4]);
    }
}