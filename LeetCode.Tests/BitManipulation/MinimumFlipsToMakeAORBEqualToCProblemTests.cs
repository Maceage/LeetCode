using FluentAssertions;
using LeetCode.Problems.BitManipulation;

namespace LeetCode.Tests.BitManipulation;

public class MinimumFlipsToMakeAORBEqualToCProblemTests
{
    [Fact]
    public void MinFlips_TestCase_1()
    {
        // Arrange
        int a = 2;
        int b = 6;
        int c = 5;

        MinimumFlipsToMakeAORBEqualToCProblem minimumFlipsToMakeAORBEqualToCProblem = new MinimumFlipsToMakeAORBEqualToCProblem();

        // Act
        int actual = minimumFlipsToMakeAORBEqualToCProblem.MinFlips(a, b, c);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void MinFlips_TestCase_2()
    {
        // Arrange
        int a = 4;
        int b = 2;
        int c = 7;

        MinimumFlipsToMakeAORBEqualToCProblem minimumFlipsToMakeAORBEqualToCProblem = new MinimumFlipsToMakeAORBEqualToCProblem();

        // Act
        int actual = minimumFlipsToMakeAORBEqualToCProblem.MinFlips(a, b, c);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void MinFlips_TestCase_3()
    {
        // Arrange
        int a = 1;
        int b = 2;
        int c = 3;

        MinimumFlipsToMakeAORBEqualToCProblem minimumFlipsToMakeAORBEqualToCProblem = new MinimumFlipsToMakeAORBEqualToCProblem();

        // Act
        int actual = minimumFlipsToMakeAORBEqualToCProblem.MinFlips(a, b, c);

        // Assert
        actual.Should().Be(0);
    }
}