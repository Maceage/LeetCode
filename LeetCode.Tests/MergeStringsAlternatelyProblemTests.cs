using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class MergeStringsAlternatelyProblemTests
{
    [Fact]
    public void MergeAlternately_TestCase_1()
    {
        // Arrange
        string word1 = "abc";
        string word2 = "pqr";

        string expected = "apbqcr";

        MergeStringsAlternatelyProblem mergeStringsAlternatelyProblem = new MergeStringsAlternatelyProblem();

        // Act
        string actual = mergeStringsAlternatelyProblem.MergeAlternately(word1, word2);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void MergeAlternately_TestCase_2()
    {
        // Arrange
        string word1 = "ab";
        string word2 = "pqrs";

        string expected = "apbqrs";

        MergeStringsAlternatelyProblem mergeStringsAlternatelyProblem = new MergeStringsAlternatelyProblem();

        // Act
        string actual = mergeStringsAlternatelyProblem.MergeAlternately(word1, word2);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void MergeAlternately_TestCase_3()
    {
        // Arrange
        string word1 = "abcd";
        string word2 = "pq";

        string expected = "apbqcd";

        MergeStringsAlternatelyProblem mergeStringsAlternatelyProblem = new MergeStringsAlternatelyProblem();

        // Act
        string actual = mergeStringsAlternatelyProblem.MergeAlternately(word1, word2);

        // Assert
        actual.Should().Be(expected);
    }
}