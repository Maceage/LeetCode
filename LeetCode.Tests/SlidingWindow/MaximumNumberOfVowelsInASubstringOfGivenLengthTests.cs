using FluentAssertions;
using LeetCode.Problems.SlidingWindow;

namespace LeetCode.Tests.SlidingWindow;

public class MaximumNumberOfVowelsInASubstringOfGivenLengthTests
{
    [Fact]
    public void MaxVowels_TestCase_1()
    {
        // Arrange
        string s = "abciiidef";
        int k = 3;

        MaximumNumberOfVowelsInASubstringOfGivenLengthProblem vowelsInASubstringOfGivenLengthProblem = new MaximumNumberOfVowelsInASubstringOfGivenLengthProblem();

        // Act
        int actual = vowelsInASubstringOfGivenLengthProblem.MaxVowels(s, k);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void MaxVowels_TestCase_2()
    {
        // Arrange
        string s = "aeiou";
        int k = 2;

        MaximumNumberOfVowelsInASubstringOfGivenLengthProblem vowelsInASubstringOfGivenLengthProblem = new MaximumNumberOfVowelsInASubstringOfGivenLengthProblem();

        // Act
        int actual = vowelsInASubstringOfGivenLengthProblem.MaxVowels(s, k);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void MaxVowels_TestCase_3()
    {
        // Arrange
        string s = "leetcode";
        int k = 3;

        MaximumNumberOfVowelsInASubstringOfGivenLengthProblem vowelsInASubstringOfGivenLengthProblem = new MaximumNumberOfVowelsInASubstringOfGivenLengthProblem();

        // Act
        int actual = vowelsInASubstringOfGivenLengthProblem.MaxVowels(s, k);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void MaxVowels_TestCase_4()
    {
        // Arrange
        string s = "zpuerktejfp";
        int k = 3;

        MaximumNumberOfVowelsInASubstringOfGivenLengthProblem vowelsInASubstringOfGivenLengthProblem = new MaximumNumberOfVowelsInASubstringOfGivenLengthProblem();

        // Act
        int actual = vowelsInASubstringOfGivenLengthProblem.MaxVowels(s, k);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void MaxVowels_TestCase_5()
    {
        // Arrange
        string s = "pdzndkhhoujpqyex";
        int k = 5;

        MaximumNumberOfVowelsInASubstringOfGivenLengthProblem vowelsInASubstringOfGivenLengthProblem = new MaximumNumberOfVowelsInASubstringOfGivenLengthProblem();

        // Act
        int actual = vowelsInASubstringOfGivenLengthProblem.MaxVowels(s, k);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void MaxVowels_TestCase_6()
    {
        // Arrange
        string s = "tnfazcwrryitgacaabwm";
        int k = 4;

        MaximumNumberOfVowelsInASubstringOfGivenLengthProblem vowelsInASubstringOfGivenLengthProblem = new MaximumNumberOfVowelsInASubstringOfGivenLengthProblem();

        // Act
        int actual = vowelsInASubstringOfGivenLengthProblem.MaxVowels(s, k);

        // Assert
        actual.Should().Be(3);
    }
}