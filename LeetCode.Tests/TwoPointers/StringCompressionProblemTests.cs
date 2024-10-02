using FluentAssertions;
using LeetCode.Problems.TwoPointers;

namespace LeetCode.Tests.TwoPointers;

public class StringCompressionProblemTests
{
    [Fact]
    public void Compress_TestCase_1()
    {
        // Arrange
        char[] chars = ['a', 'a', 'b', 'b', 'c', 'c', 'c'];
        int expected = 6;

        StringCompressionProblem stringCompressionProblem = new StringCompressionProblem();

        // Act
        int actual = stringCompressionProblem.Compress(ref chars);

        // Assert
        actual.Should().Be(expected);

        //chars.Should().BeEquivalentTo(['a', '2', 'b', '2', 'c', '3'], options => options.WithStrictOrdering());
    }

    [Fact]
    public void Compress_TestCase_2()
    {
        // Arrange
        char[] chars = ['a'];
        int expected = 1;

        StringCompressionProblem stringCompressionProblem = new StringCompressionProblem();

        // Act
        int actual = stringCompressionProblem.Compress(ref chars);

        // Assert
        actual.Should().Be(expected);

        //chars.Should().BeEquivalentTo(['a']);
    }

    [Fact]
    public void Compress_TestCase_3()
    {
        // Arrange
        char[] chars = ['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'];
        int expected = 4;

        StringCompressionProblem stringCompressionProblem = new StringCompressionProblem();

        // Act
        int actual = stringCompressionProblem.Compress(ref chars);

        // Assert
        actual.Should().Be(expected);

        //chars.Should().BeEquivalentTo(['a', 'b', '1', '2'], options => options.WithStrictOrdering());
    }
}