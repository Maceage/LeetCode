using FluentAssertions;
using LeetCode.Problems.TwoPointers;

namespace LeetCode.Tests.TwoPointers;

public class MinimumSizeSubarraySumProblemTests
{
    [Fact]
    public void MinSubArrayLen_TestCase_1()
    {
        // Arrange
        int target = 7;
        int[] nums = [2, 3, 1, 2, 4, 3];

        MinimumSizeSubarraySumProblem minimumSizeSubarraySumProblem = new MinimumSizeSubarraySumProblem();

        // Act
        int actual = minimumSizeSubarraySumProblem.MinSubArrayLen(target, nums);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void MinSubArrayLen_TestCase_2()
    {
        // Arrange
        int target = 4;
        int[] nums = [1, 4, 4];

        MinimumSizeSubarraySumProblem minimumSizeSubarraySumProblem = new MinimumSizeSubarraySumProblem();

        // Act
        int actual = minimumSizeSubarraySumProblem.MinSubArrayLen(target, nums);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void MinSubArrayLen_TestCase_3()
    {
        // Arrange
        int target = 11;
        int[] nums = [1, 1, 1, 1, 1, 1, 1, 1];

        MinimumSizeSubarraySumProblem minimumSizeSubarraySumProblem = new MinimumSizeSubarraySumProblem();

        // Act
        int actual = minimumSizeSubarraySumProblem.MinSubArrayLen(target, nums);

        // Assert
        actual.Should().Be(0);
    }
}