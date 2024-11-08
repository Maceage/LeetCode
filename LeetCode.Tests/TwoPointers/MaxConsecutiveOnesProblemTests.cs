using FluentAssertions;
using LeetCode.Problems.TwoPointers;

namespace LeetCode.Tests.TwoPointers;

public class MaxConsecutiveOnesProblemTests
{
    [Fact]
    public void FindMaxConsecutiveOnes_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 1, 0, 1, 1, 1];

        MaxConsecutiveOnesProblem maxConsecutiveOnesProblem = new MaxConsecutiveOnesProblem();

        // Act
        int actual = maxConsecutiveOnesProblem.FindMaxConsecutiveOnes(nums);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_TestCase_2()
    {
        // Arrange
        int[] nums = [1, 0, 1, 1, 0, 1];

        MaxConsecutiveOnesProblem maxConsecutiveOnesProblem = new MaxConsecutiveOnesProblem();

        // Act
        int actual = maxConsecutiveOnesProblem.FindMaxConsecutiveOnes(nums);

        // Assert
        actual.Should().Be(2);
    }
}