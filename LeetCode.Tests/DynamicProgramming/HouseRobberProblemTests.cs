using FluentAssertions;
using LeetCode.Problems.DynamicProgramming;

namespace LeetCode.Tests.DynamicProgramming;

public class HouseRobberProblemTests
{
    [Fact]
    public void Rob_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 2, 3, 1];

        HouseRobberProblem houseRobberProblem = new HouseRobberProblem();

        // Act
        int actual = houseRobberProblem.Rob(nums);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void Rob_TestCase_2()
    {
        // Arrange
        int[] nums = [2, 7, 9, 3, 1];

        HouseRobberProblem houseRobberProblem = new HouseRobberProblem();

        // Act
        int actual = houseRobberProblem.Rob(nums);

        // Assert
        actual.Should().Be(12);
    }
}