using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class IncreasingTripletSubsequenceProblemTests
{
    [Fact]
    public void IncreasingTriplet_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4, 5];

        IncreasingTripletSubsequenceProblem increasingTripletSubsequenceProblem = new IncreasingTripletSubsequenceProblem();

        // Act
        bool actual = increasingTripletSubsequenceProblem.IncreasingTriplet(nums);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void IncreasingTriplet_TestCase_2()
    {
        // Arrange
        int[] nums = [5, 4, 3, 2, 1];

        IncreasingTripletSubsequenceProblem increasingTripletSubsequenceProblem = new IncreasingTripletSubsequenceProblem();

        // Act
        bool actual = increasingTripletSubsequenceProblem.IncreasingTriplet(nums);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void IncreasingTriplet_TestCase_3()
    {
        // Arrange
        int[] nums = [2, 1, 5, 0, 4, 6];

        IncreasingTripletSubsequenceProblem increasingTripletSubsequenceProblem = new IncreasingTripletSubsequenceProblem();

        // Act
        bool actual = increasingTripletSubsequenceProblem.IncreasingTriplet(nums);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void IncreasingTriplet_TestCase_4()
    {
        // Arrange
        int[] nums = [20, 100, 10, 12, 5, 13];

        IncreasingTripletSubsequenceProblem increasingTripletSubsequenceProblem = new IncreasingTripletSubsequenceProblem();

        // Act
        bool actual = increasingTripletSubsequenceProblem.IncreasingTriplet(nums);

        // Assert
        actual.Should().BeTrue();
    }
}