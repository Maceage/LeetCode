using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class MaxNumberOfKSumPairsProblemTests
{
    [Fact]
    public void MaxOperations_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4];
        int k = 5;

        MaxNumberOfKSumPairsProblem maxNumberOfKSumPairsProblem = new MaxNumberOfKSumPairsProblem();

        // Act
        int actual = maxNumberOfKSumPairsProblem.MaxOperations(nums, k);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void MaxOperations_TestCase_2()
    {
        // Arrange
        int[] nums = [3, 1, 3, 4, 3];
        int k = 6;

        MaxNumberOfKSumPairsProblem maxNumberOfKSumPairsProblem = new MaxNumberOfKSumPairsProblem();

        // Act
        int actual = maxNumberOfKSumPairsProblem.MaxOperations(nums, k);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void MaxOperations_TestCase_3()
    {
        // Arrange
        int[] nums = [3, 5, 1, 5];
        int k = 2;

        MaxNumberOfKSumPairsProblem maxNumberOfKSumPairsProblem = new MaxNumberOfKSumPairsProblem();

        // Act
        int actual = maxNumberOfKSumPairsProblem.MaxOperations(nums, k);

        // Assert
        actual.Should().Be(0);
    }

    [Fact]
    public void MaxOperations_TestCase_4()
    {
        // Arrange
        int[] nums = [4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4];
        int k = 2;

        MaxNumberOfKSumPairsProblem maxNumberOfKSumPairsProblem = new MaxNumberOfKSumPairsProblem();

        // Act
        int actual = maxNumberOfKSumPairsProblem.MaxOperations(nums, k);

        // Assert
        actual.Should().Be(2);
    }
}