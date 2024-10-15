using FluentAssertions;
using LeetCode.Problems.DynamicProgramming;

namespace LeetCode.Tests.DynamicProgramming;

public class NthTribonacciNumberProblemTests
{
    [Fact]
    public void Tribonacci_TestCase_1()
    {
        // Arrange
        int n = 4;

        NthTribonacciNumberProblem nthTribonacciNumberProblem = new NthTribonacciNumberProblem();

        // Act
        int actual = nthTribonacciNumberProblem.Tribonacci(n);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void Tribonacci_TestCase_2()
    {
        // Arrange
        int n = 25;

        NthTribonacciNumberProblem nthTribonacciNumberProblem = new NthTribonacciNumberProblem();

        // Act
        int actual = nthTribonacciNumberProblem.Tribonacci(n);

        // Assert
        actual.Should().Be(1389537);
    }

    [Fact]
    public void Tribonacci_TestCase_3()
    {
        // Arrange
        int n = 1;

        NthTribonacciNumberProblem nthTribonacciNumberProblem = new NthTribonacciNumberProblem();

        // Act
        int actual = nthTribonacciNumberProblem.Tribonacci(n);

        // Assert
        actual.Should().Be(1);
    }
}