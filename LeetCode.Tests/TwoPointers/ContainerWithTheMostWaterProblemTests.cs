using FluentAssertions;
using LeetCode.Problems.TwoPointers;

namespace LeetCode.Tests.TwoPointers;

public class ContainerWithTheMostWaterProblemTests
{
    [Fact]
    public void MaxArea_TestCase_1()
    {
        // Arrange
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        int expected = 49;

        ContainerWithTheMostWaterProblem containerWithTheMostWater = new ContainerWithTheMostWaterProblem();

        // Act
        int actual = containerWithTheMostWater.MaxArea(height);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void MaxArea_TestCase_2()
    {
        // Arrange
        int[] height = [1, 1];
        int expected = 1;

        ContainerWithTheMostWaterProblem containerWithTheMostWater = new ContainerWithTheMostWaterProblem();

        // Act
        int actual = containerWithTheMostWater.MaxArea(height);

        // Assert
        actual.Should().Be(expected);
    }
}