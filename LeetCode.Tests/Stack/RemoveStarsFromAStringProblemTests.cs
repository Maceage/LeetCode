using FluentAssertions;
using LeetCode.Problems.Stack;

namespace LeetCode.Tests.Stack;

public class RemoveStarsFromAStringProblemTests
{
    [Fact]
    public void RemoveStars_TestCase_1()
    {
        // Arrange
        string s = "leet**cod*e";

        RemoveStarsFromAStringProblem removeStarsFromAStringProblem = new RemoveStarsFromAStringProblem();

        // Act
        string actual = removeStarsFromAStringProblem.RemoveStars(s);

        // Assert
        actual.Should().Be("lecoe");
    }

    [Fact]
    public void RemoveStars_TestCase_2()
    {
        // Arrange
        string s = "erase*****";

        RemoveStarsFromAStringProblem removeStarsFromAStringProblem = new RemoveStarsFromAStringProblem();

        // Act
        string actual = removeStarsFromAStringProblem.RemoveStars(s);

        // Assert
        actual.Should().Be(string.Empty);
    }
}