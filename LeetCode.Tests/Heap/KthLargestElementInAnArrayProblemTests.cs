using FluentAssertions;
using LeetCode.Problems.Heap;

namespace LeetCode.Tests.Heap;

public class KthLargestElementInAnArrayProblemTests
{
    [Fact]
    public void FindKthLargest_TestCase_1()
    {
        // Arrange
        int[] nums = [3, 2, 1, 5, 6, 4];
        int k = 2;

        KthLargestElementInAnArrayProblem kthLargestElementInAnArrayProblem = new KthLargestElementInAnArrayProblem();

        // Act
        int actual = kthLargestElementInAnArrayProblem.FindKthLargest(nums, k);

        // Assert
        actual.Should().Be(5);
    }

    [Fact]
    public void FindKthLargest_TestCase_2()
    {
        // Arrange
        int[] nums = [3, 2, 3, 1, 2, 4, 5, 5, 6];
        int k = 4;

        KthLargestElementInAnArrayProblem kthLargestElementInAnArrayProblem = new KthLargestElementInAnArrayProblem();

        // Act
        int actual = kthLargestElementInAnArrayProblem.FindKthLargest(nums, k);

        // Assert
        actual.Should().Be(4);
    }
}