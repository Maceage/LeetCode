using FluentAssertions;
using LeetCode.Problems.TwoPointers;

namespace LeetCode.Tests.TwoPointers;

public class ArrayPartitionProblemTests
{
    [Fact]
    public void ArrayPairSum_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 4, 3, 2];

        ArrayPartitionProblem arrayPartitionProblem = new ArrayPartitionProblem();

        // Act
        int actual = arrayPartitionProblem.ArrayPairSum(nums);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void ArrayPairSum_TestCase_2()
    {
        // Arrange
        int[] nums = [6, 2, 6, 5, 1, 2];

        ArrayPartitionProblem arrayPartitionProblem = new ArrayPartitionProblem();

        // Act
        int actual = arrayPartitionProblem.ArrayPairSum(nums);

        // Assert
        actual.Should().Be(9);
    }
}