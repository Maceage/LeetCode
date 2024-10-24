using FluentAssertions;
using LeetCode.Problems.MonotonicStack;

namespace LeetCode.Tests.MonotonicStack;

public class DailyTemperaturesProblemTests
{
    [Fact]
    public void DailyTemperatures_TestCase_1()
    {
        // Arrange
        int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];

        DailyTemperaturesProblem dailyTemperaturesProblem = new DailyTemperaturesProblem();

        // Act
        int[] actual = dailyTemperaturesProblem.DailyTemperatures(temperatures);

        // Assert
        actual.Should().BeEquivalentTo([1, 1, 4, 2, 1, 1, 0, 0], options => options.WithStrictOrdering());
    }

    [Fact]
    public void DailyTemperatures_TestCase_2()
    {
        // Arrange
        int[] temperatures = [30, 40, 50, 60];

        DailyTemperaturesProblem dailyTemperaturesProblem = new DailyTemperaturesProblem();

        // Act
        int[] actual = dailyTemperaturesProblem.DailyTemperatures(temperatures);

        // Assert
        actual.Should().BeEquivalentTo([1, 1, 1, 0], options => options.WithStrictOrdering());
    }

    [Fact]
    public void DailyTemperatures_TestCase_3()
    {
        // Arrange
        int[] temperatures = [30, 60, 90];

        DailyTemperaturesProblem dailyTemperaturesProblem = new DailyTemperaturesProblem();

        // Act
        int[] actual = dailyTemperaturesProblem.DailyTemperatures(temperatures);

        // Assert
        actual.Should().BeEquivalentTo([1, 1, 0], options => options.WithStrictOrdering());
    }
}