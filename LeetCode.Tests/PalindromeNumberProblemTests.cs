using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class PalindromeNumberProblemTests
{
    [Fact]
    public void IsPalindrome_TestCase_1()
    {
        // Arrange
        int x = 121;

        PalindromeNumberProblem palindromeNumberProblem = new PalindromeNumberProblem();

        // Act/Assert
        palindromeNumberProblem.IsPalindrome(x).Should().BeTrue();
    }

    [Fact]
    public void IsPalindrome_TestCase_2()
    {
        // Arrange
        int x = -121;

        PalindromeNumberProblem palindromeNumberProblem = new PalindromeNumberProblem();

        // Act/Assert
        palindromeNumberProblem.IsPalindrome(x).Should().BeFalse();
    }

    [Fact]
    public void IsPalindrome_TestCase_3()
    {
        // Arrange
        int x = 10;

        PalindromeNumberProblem palindromeNumberProblem = new PalindromeNumberProblem();

        // Act/Assert
        palindromeNumberProblem.IsPalindrome(x).Should().BeFalse();
    }

    [Fact]
    public void IsPalindromeInteger_TestCase_1()
    {
        // Arrange
        int x = 121;

        PalindromeNumberProblem palindromeNumberProblem = new PalindromeNumberProblem();

        // Act/Assert
        palindromeNumberProblem.IsPalindromeInteger(x).Should().BeTrue();
    }

    [Fact]
    public void IsPalindromeInteger_TestCase_2()
    {
        // Arrange
        int x = -121;

        PalindromeNumberProblem palindromeNumberProblem = new PalindromeNumberProblem();

        // Act/Assert
        palindromeNumberProblem.IsPalindromeInteger(x).Should().BeFalse();
    }

    [Fact]
    public void IsPalindromeInteger_TestCase_3()
    {
        // Arrange
        int x = 10;

        PalindromeNumberProblem palindromeNumberProblem = new PalindromeNumberProblem();

        // Act/Assert
        palindromeNumberProblem.IsPalindromeInteger(x).Should().BeFalse();
    }
}