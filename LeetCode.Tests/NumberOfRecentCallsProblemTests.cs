using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class NumberOfRecentCallsProblemTests
{
    [Fact]
    public void RecentCounter_TestCase_1()
    {
        // Arrange
        NumberOfRecentCallsProblem.RecentCounter recentCounter = new NumberOfRecentCallsProblem.RecentCounter();

        // Act/Assert
        int actual = recentCounter.Ping(1);
        actual.Should().Be(1);

        actual = recentCounter.Ping(100);
        actual.Should().Be(2);

        actual = recentCounter.Ping(3001);
        actual.Should().Be(3);

        actual = recentCounter.Ping(3002);
        actual.Should().Be(3);

        actual = recentCounter.Ping(3005);
        actual.Should().Be(4);

        actual = recentCounter.Ping(3006);
        actual.Should().Be(5);

        actual = recentCounter.Ping(3099);
        actual.Should().Be(6);

        actual = recentCounter.Ping(3101);
        actual.Should().Be(6);
    }
}