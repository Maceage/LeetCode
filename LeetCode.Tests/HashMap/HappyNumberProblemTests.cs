using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class HappyNumberProblemTests
{
    [Fact]
    public void IsHappy_TestCase_1()
    {
        // Arrange
        int n = 19;

        HappyNumberProblem happyNumberProblem = new HappyNumberProblem();

        // Act
        bool actual = happyNumberProblem.IsHappy(n);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void IsHappy_TestCase_2()
    {
        // Arrange
        int n = 2;

        HappyNumberProblem happyNumberProblem = new HappyNumberProblem();

        // Act
        bool actual = happyNumberProblem.IsHappy(n);

        // Assert
        actual.Should().BeFalse();
    }
}