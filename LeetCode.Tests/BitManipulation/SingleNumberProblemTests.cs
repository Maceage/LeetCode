using FluentAssertions;
using LeetCode.Problems.BitManipulation;

namespace LeetCode.Tests.BitManipulation;

public class SingleNumberProblemTests
{
    [Fact]
    public void SingleNumber_TestCase_1()
    {
        // Arrange
        int[] nums = [2, 2, 1];

        SingleNumberProblem singleNumberProblem = new SingleNumberProblem();

        // Act
        int actual = singleNumberProblem.SingleNumber(nums);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void SingleNumber_TestCase_2()
    {
        // Arrange
        int[] nums = [4, 1, 2, 1, 2];

        SingleNumberProblem singleNumberProblem = new SingleNumberProblem();

        // Act
        int actual = singleNumberProblem.SingleNumber(nums);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void SingleNumber_TestCase_3()
    {
        // Arrange
        int[] nums = [1];

        SingleNumberProblem singleNumberProblem = new SingleNumberProblem();

        // Act
        int actual = singleNumberProblem.SingleNumber(nums);

        // Assert
        actual.Should().Be(1);
    }
}