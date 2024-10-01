using FluentAssertions;
using LeetCode.Problems.SlidingWindow;

namespace LeetCode.Tests.SlidingWindow;

public class MaximumAverageSubarrayProblemTests
{
    [Fact]
    public void FindMaxAverage_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 12, -5, -6, 50, 3];
        int k = 4;

        MaximumAverageSubarrayProblem maximumAverageSubarrayProblem = new MaximumAverageSubarrayProblem();

        // Act
        double actual = maximumAverageSubarrayProblem.FindMaxAverage(nums, k);

        // Assert
        actual.Should().Be(12.75);
    }

    [Fact]
    public void FindMaxAverage_TestCase_2()
    {
        // Arrange
        int[] nums = [5];
        int k = 1;

        MaximumAverageSubarrayProblem maximumAverageSubarrayProblem = new MaximumAverageSubarrayProblem();

        // Act
        double actual = maximumAverageSubarrayProblem.FindMaxAverage(nums, k);

        // Assert
        actual.Should().Be(5);
    }
}