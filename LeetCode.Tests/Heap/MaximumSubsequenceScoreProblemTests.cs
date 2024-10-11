using FluentAssertions;
using LeetCode.Problems.Heap;

namespace LeetCode.Tests.Heap;

public class MaximumSubsequenceScoreProblemTests
{
    [Fact]
    public void MaxScore_TestCase_1()
    {
        // Arrange
        int[] nums1 = [1, 3, 3, 2];
        int[] nums2 = [2, 1, 3, 4];

        int k = 3;

        MaximumSubsequenceScoreProblem maximumSubsequenceScoreProblem = new MaximumSubsequenceScoreProblem();

        // Act
        long actual = maximumSubsequenceScoreProblem.MaxScore(nums1, nums2, k);

        // Assert
        actual.Should().Be(12);
    }

    [Fact]
    public void MaxScore_TestCase_2()
    {
        // Arrange
        int[] nums1 = [4, 2, 3, 1, 1];
        int[] nums2 = [7, 5, 10, 9, 6];

        int k = 1;

        MaximumSubsequenceScoreProblem maximumSubsequenceScoreProblem = new MaximumSubsequenceScoreProblem();

        // Act
        long actual = maximumSubsequenceScoreProblem.MaxScore(nums1, nums2, k);

        // Assert
        actual.Should().Be(30);
    }

    [Fact]
    public void MaxScore_TestCase_3()
    {
        // Arrange
        int[] nums1 = [2, 1, 14, 12];
        int[] nums2 = [11, 7, 13, 6];

        int k = 3;

        MaximumSubsequenceScoreProblem maximumSubsequenceScoreProblem = new MaximumSubsequenceScoreProblem();

        // Act
        long actual = maximumSubsequenceScoreProblem.MaxScore(nums1, nums2, k);

        // Assert
        actual.Should().Be(168);
    }
}