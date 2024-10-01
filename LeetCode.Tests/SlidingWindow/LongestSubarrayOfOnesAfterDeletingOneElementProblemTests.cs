using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests.SlidingWindow;

public class LongestSubarrayOfOnesAfterDeletingOneElementProblemTests
{
    [Fact]
    public void LongestSubarray_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 1, 0, 1];

        LongestSubarrayOfOnesAfterDeletingOneElementProblem longestSubarrayOfOnesAfterDeletingOneElementProblem = new LongestSubarrayOfOnesAfterDeletingOneElementProblem();

        // Act
        int actual = longestSubarrayOfOnesAfterDeletingOneElementProblem.LongestSubarray(nums);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void LongestSubarray_TestCase_2()
    {
        // Arrange
        int[] nums = [0, 1, 1, 1, 0, 1, 1, 0, 1];

        LongestSubarrayOfOnesAfterDeletingOneElementProblem longestSubarrayOfOnesAfterDeletingOneElementProblem = new LongestSubarrayOfOnesAfterDeletingOneElementProblem();

        // Act
        int actual = longestSubarrayOfOnesAfterDeletingOneElementProblem.LongestSubarray(nums);

        // Assert
        actual.Should().Be(5);
    }

    [Fact]
    public void LongestSubarray_TestCase_3()
    {
        // Arrange
        int[] nums = [1, 1, 1];

        LongestSubarrayOfOnesAfterDeletingOneElementProblem longestSubarrayOfOnesAfterDeletingOneElementProblem = new LongestSubarrayOfOnesAfterDeletingOneElementProblem();

        // Act
        int actual = longestSubarrayOfOnesAfterDeletingOneElementProblem.LongestSubarray(nums);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void LongestSubarray_TestCase_4()
    {
        // Arrange
        int[] nums = [1];

        LongestSubarrayOfOnesAfterDeletingOneElementProblem longestSubarrayOfOnesAfterDeletingOneElementProblem = new LongestSubarrayOfOnesAfterDeletingOneElementProblem();

        // Act
        int actual = longestSubarrayOfOnesAfterDeletingOneElementProblem.LongestSubarray(nums);

        // Assert
        actual.Should().Be(0);
    }
}