using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests.Array;

public class ReverseVowelsOfAStringProblemTests
{
    [Fact]
    public void ReverseVowels_TestCase_1()
    {
        // Arrange
        string s = "hello";
        string expected = "holle";

        ReverseVowelsOfAStringProblem reverseVowelsOfAStringProblem = new ReverseVowelsOfAStringProblem();

        // Act
        string actual = reverseVowelsOfAStringProblem.ReverseVowels(s);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void ReverseVowels_TestCase_2()
    {
        // Arrange
        string s = "leetcode";
        string expected = "leotcede";

        ReverseVowelsOfAStringProblem reverseVowelsOfAStringProblem = new ReverseVowelsOfAStringProblem();

        // Act
        string actual = reverseVowelsOfAStringProblem.ReverseVowels(s);

        // Assert
        actual.Should().Be(expected);
    }
}