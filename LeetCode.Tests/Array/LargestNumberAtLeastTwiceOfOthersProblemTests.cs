using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class LargestNumberAtLeastTwiceOfOthersProblemTests
{
    [Fact]
    public void DominantIndex_TestCase_1()
    {
        // Arrange
        int[] nums = [3, 6, 1, 0];

        LargestNumberAtLeastTwiceOfOthersProblem largestNumberAtLeastTwiceOfOthersProblem = new LargestNumberAtLeastTwiceOfOthersProblem();

        // Act
        int actual = largestNumberAtLeastTwiceOfOthersProblem.DominantIndex(nums);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void DominantIndex_TestCase_2()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4];

        LargestNumberAtLeastTwiceOfOthersProblem largestNumberAtLeastTwiceOfOthersProblem = new LargestNumberAtLeastTwiceOfOthersProblem();

        // Act
        int actual = largestNumberAtLeastTwiceOfOthersProblem.DominantIndex(nums);

        // Assert
        actual.Should().Be(-1);
    }
}