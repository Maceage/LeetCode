using FluentAssertions;
using LeetCode.Problems.DynamicProgramming;

namespace LeetCode.Tests.DynamicProgramming;

public class MinCostClimbingStairsProblemTests
{
    [Fact]
    public void MinCostClimbingStairs_TestCase_1()
    {
        // Arrange
        int[] cost = [10, 15, 20];

        MinCostClimbingStairsProblem minCostClimbingStairsProblem = new MinCostClimbingStairsProblem();

        // Act
        int actual = minCostClimbingStairsProblem.MinCostClimbingStairs(cost);

        // Assert
        actual.Should().Be(15);
    }

    [Fact]
    public void MinCostClimbingStairs_TestCase_2()
    {
        // Arrange
        int[] cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];

        MinCostClimbingStairsProblem minCostClimbingStairsProblem = new MinCostClimbingStairsProblem();

        // Act
        int actual = minCostClimbingStairsProblem.MinCostClimbingStairs(cost);

        // Assert
        actual.Should().Be(6);
    }
}