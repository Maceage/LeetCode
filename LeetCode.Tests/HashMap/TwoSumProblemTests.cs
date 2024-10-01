using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class TwoSumProblemTests
{
    [Fact]
    public void TwoSum_Case_1()
    {
        // Arrange
        int[] expected = [0, 1];

        int[] numbers = [2, 7, 11, 15];
        int target = 9;

        TwoSumProblem twoSumProblem = new TwoSumProblem();

        // Act
        int[] actual = twoSumProblem.TwoSum(numbers, target);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void TwoSum_Case_2()
    {
        // Arrange
        int[] expected = [1, 2];

        int[] numbers = [3, 2, 4];
        int target = 6;

        TwoSumProblem twoSumProblem = new TwoSumProblem();

        // Act
        int[] actual = twoSumProblem.TwoSum(numbers, target);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void TwoSum_Case_3()
    {
        // Arrange
        int[] expected = [0, 1];

        int[] numbers = [3, 3];
        int target = 6;

        TwoSumProblem twoSumProblem = new TwoSumProblem();

        // Act
        int[] actual = twoSumProblem.TwoSum(numbers, target);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
}