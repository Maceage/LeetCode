using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class ReverseWordsInAStringProblemTests
{
    [Fact]
    public void ReverseWords_TestCase_1()
    {
        // Arrange
        string s = "the sky is blue";
        string expected = "blue is sky the";

        ReverseWordsInAStringProblem reverseWordsInAStringProblem = new ReverseWordsInAStringProblem();

        // Act
        string actual = reverseWordsInAStringProblem.ReverseWords(s);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void ReverseWords_TestCase_2()
    {
        // Arrange
        string s = "  hello world  ";
        string expected = "world hello";

        ReverseWordsInAStringProblem reverseWordsInAStringProblem = new ReverseWordsInAStringProblem();

        // Act
        string actual = reverseWordsInAStringProblem.ReverseWords(s);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void ReverseWords_TestCase_3()
    {
        // Arrange
        string s = "a good   example";
        string expected = "example good a";

        ReverseWordsInAStringProblem reverseWordsInAStringProblem = new ReverseWordsInAStringProblem();

        // Act
        string actual = reverseWordsInAStringProblem.ReverseWords(s);

        // Assert
        actual.Should().Be(expected);
    }
}