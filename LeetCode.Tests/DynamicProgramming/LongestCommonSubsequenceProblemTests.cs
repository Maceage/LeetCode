using FluentAssertions;
using LeetCode.Problems.DynamicProgramming;

namespace LeetCode.Tests.DynamicProgramming;

public class LongestCommonSubsequenceProblemTests
{
    [Fact]
    public void LongestCommonSubsequence_TestCase_1()
    {
        // Arrange
        string text1 = "abcde";
        string text2 = "ace";

        LongestCommonSubsequenceProblem longestCommonSubsequenceProblem = new LongestCommonSubsequenceProblem();

        // Act
        int actual = longestCommonSubsequenceProblem.LongestCommonSubsequence(text1, text2);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void LongestCommonSubsequence_TestCase_2()
    {
        // Arrange
        string text1 = "abc";
        string text2 = "abc";

        LongestCommonSubsequenceProblem longestCommonSubsequenceProblem = new LongestCommonSubsequenceProblem();

        // Act
        int actual = longestCommonSubsequenceProblem.LongestCommonSubsequence(text1, text2);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void LongestCommonSubsequence_TestCase_3()
    {
        // Arrange
        string text1 = "abc";
        string text2 = "def";

        LongestCommonSubsequenceProblem longestCommonSubsequenceProblem = new LongestCommonSubsequenceProblem();

        // Act
        int actual = longestCommonSubsequenceProblem.LongestCommonSubsequence(text1, text2);

        // Assert
        actual.Should().Be(0);
    }
}