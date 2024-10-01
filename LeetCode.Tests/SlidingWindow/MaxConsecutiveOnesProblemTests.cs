using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests.SlidingWindow;

public class MaxConsecutiveOnesProblemTests
{
    [Fact]
    public void LongestOnes_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
        int k = 2;

        MaxConsecutiveOnesProblem maxConsecutiveOnesProblem = new MaxConsecutiveOnesProblem();

        // Act
        int actual = maxConsecutiveOnesProblem.LongestOnes(nums, k);

        // Assert
        actual.Should().Be(6);
    }

    [Fact]
    public void LongestOnes_TestCase_2()
    {
        // Arrange
        int[] nums = [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1];
        int k = 3;

        MaxConsecutiveOnesProblem maxConsecutiveOnesProblem = new MaxConsecutiveOnesProblem();

        // Act
        int actual = maxConsecutiveOnesProblem.LongestOnes(nums, k);

        // Assert
        actual.Should().Be(10);
    }
}