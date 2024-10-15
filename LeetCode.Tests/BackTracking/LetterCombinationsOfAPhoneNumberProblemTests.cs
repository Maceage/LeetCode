using FluentAssertions;
using LeetCode.Problems.Backtracking;

namespace LeetCode.Tests.BackTracking;

public class LetterCombinationsOfAPhoneNumberProblemTests
{
    [Fact]
    public void LetterCombinations_TestCase_1()
    {
        // Arrange
        string digits = "23";

        LetterCombinationsOfAPhoneNumberProblem letterCombinationsOfAPhoneNumber = new LetterCombinationsOfAPhoneNumberProblem();

        // Act
        IList<string> actual = letterCombinationsOfAPhoneNumber.LetterCombinations(digits);

        // Assert
        actual.Should().BeEquivalentTo(["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"], options => options.WithStrictOrdering());
    }

    [Fact]
    public void LetterCombinations_TestCase_2()
    {
        // Arrange
        string digits = "";

        LetterCombinationsOfAPhoneNumberProblem letterCombinationsOfAPhoneNumber = new LetterCombinationsOfAPhoneNumberProblem();

        // Act
        IList<string> actual = letterCombinationsOfAPhoneNumber.LetterCombinations(digits);

        // Assert
        actual.Should().BeEquivalentTo([], options => options.WithStrictOrdering());
    }

    [Fact]
    public void LetterCombinations_TestCase_3()
    {
        // Arrange
        string digits = "2";

        LetterCombinationsOfAPhoneNumberProblem letterCombinationsOfAPhoneNumber = new LetterCombinationsOfAPhoneNumberProblem();

        // Act
        IList<string> actual = letterCombinationsOfAPhoneNumber.LetterCombinations(digits);

        // Assert
        actual.Should().BeEquivalentTo(["a", "b", "c"], options => options.WithStrictOrdering());
    }
}