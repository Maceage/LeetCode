using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests.TwoPointers;

public class IsSubsequenceProblemTests
{
    [Fact]
    public void IsSubsequence_TestCase_1()
    {
        // Arrange
        string s = "abc";
        string t = "ahbgdc";

        IsSubsequenceProblem isSubsequenceProblem = new IsSubsequenceProblem();

        // Act
        bool actual = isSubsequenceProblem.IsSubsequence(s, t);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void IsSubsequence_TestCase_2()
    {
        // Arrange
        string s = "axc";
        string t = "ahbgdc";

        IsSubsequenceProblem isSubsequenceProblem = new IsSubsequenceProblem();

        // Act
        bool actual = isSubsequenceProblem.IsSubsequence(s, t);

        // Assert
        actual.Should().BeFalse();
    }
}