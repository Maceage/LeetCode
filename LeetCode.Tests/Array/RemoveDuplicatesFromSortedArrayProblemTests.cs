using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class RemoveDuplicatesFromSortedArrayProblemTests
{
    [Fact]
    public void RemoveDuplicates_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 1, 2];
        int[] expectedNums = [1, 2];

        RemoveDuplicatesFromSortedArrayProblem removeDuplicatesFromSortedArrayProblem = new RemoveDuplicatesFromSortedArrayProblem();

        // Act
        int actual = removeDuplicatesFromSortedArrayProblem.RemoveDuplicates(nums);

        // Assert
        actual.Should().Be(2);

        for (int i = 0; i < expectedNums.Length; i++)
        {
            nums[i].Should().Be(expectedNums[i]);
        }
    }

    [Fact]
    public void RemoveDuplicates_TestCase_2()
    {
        // Arrange
        int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        int[] expectedNums = [0, 1, 2, 3, 4];

        RemoveDuplicatesFromSortedArrayProblem removeDuplicatesFromSortedArrayProblem = new RemoveDuplicatesFromSortedArrayProblem();

        // Act
        int actual = removeDuplicatesFromSortedArrayProblem.RemoveDuplicates(nums);

        // Assert
        actual.Should().Be(5);

        for (int i = 0; i < expectedNums.Length; i++)
        {
            nums[i].Should().Be(expectedNums[i]);
        }
    }
}