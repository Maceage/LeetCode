using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class ReverseWordsInAString3ProblemTests
{
    [Fact]
    public void ReverseWords_TestCase_1()
    {
        // Arrange
        string s = "Let's take LeetCode contest";

        ReverseWordsInAString3Problem reverseWordsInAString3Problem = new ReverseWordsInAString3Problem();

        // Act
        string actual = reverseWordsInAString3Problem.ReverseWords(s);

        // Assert
        actual.Should().Be("s'teL ekat edoCteeL tsetnoc");
    }

    [Fact]
    public void ReverseWords_TestCase_2()
    {
        // Arrange
        string s = "Mr Ding";

        ReverseWordsInAString3Problem reverseWordsInAString3Problem = new ReverseWordsInAString3Problem();

        // Act
        string actual = reverseWordsInAString3Problem.ReverseWords(s);

        // Assert
        actual.Should().Be("rM gniD");
    }
}