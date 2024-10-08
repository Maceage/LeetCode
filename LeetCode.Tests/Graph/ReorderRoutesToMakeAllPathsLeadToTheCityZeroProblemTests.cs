using FluentAssertions;
using LeetCode.Problems.Graph;

namespace LeetCode.Tests.Graph;

public class ReorderRoutesToMakeAllPathsLeadToTheCityZeroProblemTests
{
    [Fact]
    public void MinReorder_TestCase_1()
    {
        // Arrange
        int n = 6;
        int[][] connections = [[0, 1], [1, 3], [2, 3], [4, 0], [4, 5]];

        int expected = 3;

        ReorderRoutesToMakeAllPathsLeadToTheCityZeroProblem reorderRoutesToMakeAllPathsLeadToTheCityZeroProblem = new ReorderRoutesToMakeAllPathsLeadToTheCityZeroProblem();

        // Act
        int actual = reorderRoutesToMakeAllPathsLeadToTheCityZeroProblem.MinReorder(n, connections);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void MinReorder_TestCase_2()
    {
        // Arrange
        int n = 5;
        int[][] connections = [[1, 0], [1, 2], [3, 2], [3, 4]];

        int expected = 2;

        ReorderRoutesToMakeAllPathsLeadToTheCityZeroProblem reorderRoutesToMakeAllPathsLeadToTheCityZeroProblem = new ReorderRoutesToMakeAllPathsLeadToTheCityZeroProblem();

        // Act
        int actual = reorderRoutesToMakeAllPathsLeadToTheCityZeroProblem.MinReorder(n, connections);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void MinReorder_TestCase_3()
    {
        // Arrange
        int n = 3;
        int[][] connections = [[1, 0], [2, 0]];

        int expected = 0;

        ReorderRoutesToMakeAllPathsLeadToTheCityZeroProblem reorderRoutesToMakeAllPathsLeadToTheCityZeroProblem = new ReorderRoutesToMakeAllPathsLeadToTheCityZeroProblem();

        // Act
        int actual = reorderRoutesToMakeAllPathsLeadToTheCityZeroProblem.MinReorder(n, connections);

        // Assert
        actual.Should().Be(expected);
    }
}