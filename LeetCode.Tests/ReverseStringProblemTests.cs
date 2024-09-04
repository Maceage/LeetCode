using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class ReverseStringProblemTests
{
    [Fact]
    public void ReverseString_TestCase_1()
    {
        // Arrange
        char[] s = ['h', 'e', 'l', 'l', 'o'];
        char[] expected = ['o', 'l', 'l', 'e', 'h'];

        ReverseStringProblem reverseStringProblem = new ReverseStringProblem();

        // Act
        reverseStringProblem.ReverseString(s);

        // Assert
        s.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());
    }

    [Fact]
    public void ReverseString_TestCase_2()
    {
        // Arrange
        char[] s = ['H', 'a', 'n', 'n', 'a', 'h'];
        char[] expected = ['h', 'a', 'n', 'n', 'a', 'H'];

        ReverseStringProblem reverseStringProblem = new ReverseStringProblem();

        // Act
        reverseStringProblem.ReverseString(s);

        // Assert
        s.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering());
    }
}