using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class DetermineIfTwoStringsAreCloseProblemTests
{
    [Fact]
    public void CloseStrings_TestCase_1()
    {
        // Arrange
        string word1 = "abc";
        string word2 = "bca";

        DetermineIfTwoStringsAreCloseProblem determineIfTwoStringsAreCloseProblem = new DetermineIfTwoStringsAreCloseProblem();

        // Act
        bool actual = determineIfTwoStringsAreCloseProblem.CloseStrings(word1, word2);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void CloseStrings_TestCase_2()
    {
        // Arrange
        string word1 = "a";
        string word2 = "aa";

        DetermineIfTwoStringsAreCloseProblem determineIfTwoStringsAreCloseProblem = new DetermineIfTwoStringsAreCloseProblem();

        // Act
        bool actual = determineIfTwoStringsAreCloseProblem.CloseStrings(word1, word2);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void CloseStrings_TestCase_3()
    {
        // Arrange
        string word1 = "cabbba";
        string word2 = "abbccc";

        DetermineIfTwoStringsAreCloseProblem determineIfTwoStringsAreCloseProblem = new DetermineIfTwoStringsAreCloseProblem();

        // Act
        bool actual = determineIfTwoStringsAreCloseProblem.CloseStrings(word1, word2);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void CloseStrings_TestCase_4()
    {
        // Arrange
        string word1 = "cabbba";
        string word2 = "aabbss";

        DetermineIfTwoStringsAreCloseProblem determineIfTwoStringsAreCloseProblem = new DetermineIfTwoStringsAreCloseProblem();

        // Act
        bool actual = determineIfTwoStringsAreCloseProblem.CloseStrings(word1, word2);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void CloseStrings_TestCase_5()
    {
        // Arrange
        string word1 = "uau";
        string word2 = "ssx";

        DetermineIfTwoStringsAreCloseProblem determineIfTwoStringsAreCloseProblem = new DetermineIfTwoStringsAreCloseProblem();

        // Act
        bool actual = determineIfTwoStringsAreCloseProblem.CloseStrings(word1, word2);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void CloseStrings_TestCase_6()
    {
        // Arrange
        string word1 = "abbzzca";
        string word2 = "babzzcz";

        DetermineIfTwoStringsAreCloseProblem determineIfTwoStringsAreCloseProblem = new DetermineIfTwoStringsAreCloseProblem();

        // Act
        bool actual = determineIfTwoStringsAreCloseProblem.CloseStrings(word1, word2);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void CloseStrings_TestCase_7()
    {
        // Arrange
        string word1 = "abbzzcf";
        string word2 = "babzzcz";

        DetermineIfTwoStringsAreCloseProblem determineIfTwoStringsAreCloseProblem = new DetermineIfTwoStringsAreCloseProblem();

        // Act
        bool actual = determineIfTwoStringsAreCloseProblem.CloseStrings(word1, word2);

        // Assert
        actual.Should().BeFalse();
    }
}