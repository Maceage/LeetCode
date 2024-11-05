using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class SpiralMatrixProblemTests
{
    [Fact]
    public void SpiralOrder_TestCase_1()
    {
        // Arrange
        int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

        SpiralMatrixProblem spiralMatrixProblem = new SpiralMatrixProblem();

        // Act
        IList<int> actual = spiralMatrixProblem.SpiralOrder(matrix);

        // Assert
        actual.Should().BeEquivalentTo([1, 2, 3, 6, 9, 8, 7, 4, 5], options => options.WithStrictOrdering());
    }

    [Fact]
    public void SpiralOrder_TestCase_2()
    {
        // Arrange
        int[][] matrix = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]];

        SpiralMatrixProblem spiralMatrixProblem = new SpiralMatrixProblem();

        // Act
        IList<int> actual = spiralMatrixProblem.SpiralOrder(matrix);

        // Assert
        actual.Should().BeEquivalentTo([1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7], options => options.WithStrictOrdering());
    }
}