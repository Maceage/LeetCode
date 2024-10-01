using FluentAssertions;
using LeetCode.Problems.Stack;

namespace LeetCode.Tests.Stack;

public class DecodeStringProblemTests
{
    [Fact]
    public void DecodeString_TestCase_1()
    {
        // Arrange
        string s = "3[a]2[bc]";

        DecodeStringProblem decodeStringProblem = new DecodeStringProblem();

        // Act
        string actual = decodeStringProblem.DecodeString(s);

        // Assert
        actual.Should().Be("aaabcbc");
    }

    [Fact]
    public void DecodeString_TestCase_2()
    {
        // Arrange
        string s = "3[a2[c]]";

        DecodeStringProblem decodeStringProblem = new DecodeStringProblem();

        // Act
        string actual = decodeStringProblem.DecodeString(s);

        // Assert
        actual.Should().Be("accaccacc");
    }

    [Fact]
    public void DecodeString_TestCase_3()
    {
        // Arrange
        string s = "2[abc]3[cd]ef";

        DecodeStringProblem decodeStringProblem = new DecodeStringProblem();

        // Act
        string actual = decodeStringProblem.DecodeString(s);

        // Assert
        actual.Should().Be("abcabccdcdcdef");
    }

    [Fact]
    public void DecodeString_TestCase_4()
    {
        // Arrange
        string s = "12[abc]12[cd]ef";

        DecodeStringProblem decodeStringProblem = new DecodeStringProblem();

        // Act
        string actual = decodeStringProblem.DecodeString(s);

        // Assert
        actual.Should().Be("abcabcabcabcabcabcabcabcabcabcabcabccdcdcdcdcdcdcdcdcdcdcdcdef");
    }
}