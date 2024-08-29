using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class RomanToIntegerProblemTests
{
    [Fact]
    public void RomanToInt_TestCase_1()
    {
        // Arrange
        string s = "III";
        
        RomanToIntegerProblem romanToIntegerProblem = new RomanToIntegerProblem();

        // Act/Assert
        // III = 3
        romanToIntegerProblem.RomanToInt(s).Should().Be(3);
    }

    [Fact]
    public void RomanToInt_TestCase_2()
    {
        // Arrange
        string s = "LVIII";

        RomanToIntegerProblem romanToIntegerProblem = new RomanToIntegerProblem();

        // Act/Assert
        // L = 50, V= 5, III = 3
        romanToIntegerProblem.RomanToInt(s).Should().Be(58);
    }

    [Fact]
    public void RomanToInt_TestCase_3()
    {
        // Arrange
        string s = "MCMXCIV";

        RomanToIntegerProblem romanToIntegerProblem = new RomanToIntegerProblem();

        // Act/Assert
        // M = 1000, CM = 900, XC = 90 and IV = 4
        romanToIntegerProblem.RomanToInt(s).Should().Be(1994);
    }
}