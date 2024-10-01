using FluentAssertions;
using LeetCode.Problems.PrefixSum;

namespace LeetCode.Tests.PrefixSum;

public class FindPivotIndexProblemTests
{
    [Fact]
    public void PivotIndex_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 7, 3, 6, 5, 6];

        FindPivotIndexProblem findPivotIndexProblem = new FindPivotIndexProblem();

        // Act
        int actual = findPivotIndexProblem.PivotIndex(nums);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void PivotIndex_TestCase_2()
    {
        // Arrange
        int[] nums = [1, 2, 3];

        FindPivotIndexProblem findPivotIndexProblem = new FindPivotIndexProblem();

        // Act
        int actual = findPivotIndexProblem.PivotIndex(nums);

        // Assert
        actual.Should().Be(-1);
    }

    [Fact]
    public void PivotIndex_TestCase_3()
    {
        // Arrange
        int[] nums = [2, 1, -1];

        FindPivotIndexProblem findPivotIndexProblem = new FindPivotIndexProblem();

        // Act
        int actual = findPivotIndexProblem.PivotIndex(nums);

        // Assert
        actual.Should().Be(0);
    }
}