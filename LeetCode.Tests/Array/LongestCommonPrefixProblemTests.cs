using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class LongestCommonPrefixProblemTests
{
    [Fact]
    public void LongestCommonPrefix_TestCase_1()
    {
        // Arrange
        string[] strings = ["flower", "flow", "flight"];

        // Act
        LongestCommonPrefixProblem longestCommonPrefixProblem = new LongestCommonPrefixProblem();

        // Assert
        longestCommonPrefixProblem.LongestCommonPrefix(strings).Should().Be("fl");
    }

    [Fact]
    public void LongestCommonPrefix_TestCase_2()
    {
        string[] strings = ["dog", "racecar", "car"];

        // Act
        LongestCommonPrefixProblem longestCommonPrefixProblem = new LongestCommonPrefixProblem();

        // Assert
        longestCommonPrefixProblem.LongestCommonPrefix(strings).Should().BeEmpty();
    }
}