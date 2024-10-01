using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests.HashMap;

public class EqualRowAndColumnPairsProblemTests
{
    [Fact]
    public void EqualPairs_TestCase_1()
    {
        // Arrange
        int[][] grid = [[3, 2, 1], [1, 7, 6], [2, 7, 7]];

        EqualRowAndColumnPairsProblem equalRowAndColumnPairsProblem = new EqualRowAndColumnPairsProblem();

        // Act
        int actual = equalRowAndColumnPairsProblem.EqualPairs(grid);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void EqualPairs_TestCase_2()
    {
        // Arrange
        int[][] grid = [[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]];

        EqualRowAndColumnPairsProblem equalRowAndColumnPairsProblem = new EqualRowAndColumnPairsProblem();

        // Act
        int actual = equalRowAndColumnPairsProblem.EqualPairs(grid);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void EqualPairs_TestCase_3()
    {
        // Arrange
        int[][] grid = [[3, 2, 1], [1, 7, 6], [2, 7, 7]];

        EqualRowAndColumnPairsProblem equalRowAndColumnPairsProblem = new EqualRowAndColumnPairsProblem();

        // Act
        int actual = equalRowAndColumnPairsProblem.EqualPairs(grid);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void EqualPairs_TestCase_4()
    {
        // Arrange
        int[][] grid = [[11, 1], [1, 11]];

        EqualRowAndColumnPairsProblem equalRowAndColumnPairsProblem = new EqualRowAndColumnPairsProblem();

        // Act
        int actual = equalRowAndColumnPairsProblem.EqualPairs(grid);

        // Assert
        actual.Should().Be(2);
    }
}