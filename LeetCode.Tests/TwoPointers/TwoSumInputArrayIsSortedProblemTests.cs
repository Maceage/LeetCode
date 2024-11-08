using FluentAssertions;
using LeetCode.Problems.TwoPointers;

namespace LeetCode.Tests.TwoPointers;

public class TwoSumInputArrayIsSortedProblemTests
{
    [Fact]
    public void TwoSum_TestCase_1()
    {
        // Arrange
        int[] numbers = [2, 7, 11, 15];
        int target = 9;

        TwoSumInputArrayIsSortedProblem twoSumInputArrayIsSortedProblem = new TwoSumInputArrayIsSortedProblem();

        // Act
        int[] actual = twoSumInputArrayIsSortedProblem.TwoSum(numbers, target);

        // Assert
        actual.Should().BeEquivalentTo([1, 2], options => options.WithStrictOrdering());
    }

    [Fact]
    public void TwoSum_TestCase_2()
    {
        // Arrange
        int[] numbers = [2, 3, 4];
        int target = 6;

        TwoSumInputArrayIsSortedProblem twoSumInputArrayIsSortedProblem = new TwoSumInputArrayIsSortedProblem();

        // Act
        int[] actual = twoSumInputArrayIsSortedProblem.TwoSum(numbers, target);

        // Assert
        actual.Should().BeEquivalentTo([1, 3], options => options.WithStrictOrdering());
    }

    [Fact]
    public void TwoSum_TestCase_3()
    {
        // Arrange
        int[] numbers = [-1, 0];
        int target = -1;

        TwoSumInputArrayIsSortedProblem twoSumInputArrayIsSortedProblem = new TwoSumInputArrayIsSortedProblem();

        // Act
        int[] actual = twoSumInputArrayIsSortedProblem.TwoSum(numbers, target);

        // Assert
        actual.Should().BeEquivalentTo([1, 2], options => options.WithStrictOrdering());
    }

    [Fact]
    public void TwoSum_TestCase_4()
    {
        // Arrange
        int[] numbers = [-5, -3, 0, 2, 4, 6, 8];
        int target = 5;

        TwoSumInputArrayIsSortedProblem twoSumInputArrayIsSortedProblem = new TwoSumInputArrayIsSortedProblem();

        // Act
        int[] actual = twoSumInputArrayIsSortedProblem.TwoSum(numbers, target);

        // Assert
        actual.Should().BeEquivalentTo([2, 7], options => options.WithStrictOrdering());
    }
}