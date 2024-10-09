using FluentAssertions;
using LeetCode.Problems.Graph;

namespace LeetCode.Tests.Graph;

public class RottingOrangesProblemTests
{
    [Fact]
    public void OrangesRotting_TestCase_1()
    {
        // Arrange
        int[][] grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];

        RottingOrangesProblem rottingOrangesProblem = new RottingOrangesProblem();

        // Act
        int actual = rottingOrangesProblem.OrangesRotting(grid);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void OrangesRotting_TestCase_2()
    {
        // Arrange
        int[][] grid = [[2, 1, 1], [0, 1, 1], [1, 0, 1]];

        RottingOrangesProblem rottingOrangesProblem = new RottingOrangesProblem();

        // Act
        int actual = rottingOrangesProblem.OrangesRotting(grid);

        // Assert
        actual.Should().Be(-1);
    }

    [Fact]
    public void OrangesRotting_TestCase_3()
    {
        // Arrange
        int[][] grid = [[0, 2]];

        RottingOrangesProblem rottingOrangesProblem = new RottingOrangesProblem();

        // Act
        int actual = rottingOrangesProblem.OrangesRotting(grid);

        // Assert
        actual.Should().Be(0);
    }
}