using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class GreatestCommonDivisorOfStringsProblemTests
{
    [Fact]
    public void GcdOfStrings_TestCase_1()
    {
        // Arrange
        string string1 = "ABCABC";
        string string2 = "ABC";

        GreatestCommonDivisorOfStringsProblem greatestCommonDivisorOfStringsProblem = new GreatestCommonDivisorOfStringsProblem();

        // Act
        string actual = greatestCommonDivisorOfStringsProblem.GcdOfStrings(string1, string2);

        // Assert
        actual.Should().Be("ABC");
    }

    [Fact]
    public void GcdOfStrings_TestCase_2()
    {
        // Arrange
        string string1 = "ABABAB";
        string string2 = "ABAB";

        GreatestCommonDivisorOfStringsProblem greatestCommonDivisorOfStringsProblem = new GreatestCommonDivisorOfStringsProblem();

        // Act
        string actual = greatestCommonDivisorOfStringsProblem.GcdOfStrings(string1, string2);

        // Assert
        actual.Should().Be("AB");
    }

    [Fact]
    public void GcdOfStrings_TestCase_3()
    {
        // Arrange
        string string1 = "LEET";
        string string2 = "CODE";

        GreatestCommonDivisorOfStringsProblem greatestCommonDivisorOfStringsProblem = new GreatestCommonDivisorOfStringsProblem();

        // Act
        string actual = greatestCommonDivisorOfStringsProblem.GcdOfStrings(string1, string2);

        // Assert
        actual.Should().Be(string.Empty);
    }
}