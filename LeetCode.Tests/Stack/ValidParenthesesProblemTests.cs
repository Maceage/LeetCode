using FluentAssertions;
using LeetCode.Problems.Stack;

namespace LeetCode.Tests.Stack;

public class ValidParenthesesProblemTests
{
    [Fact]
    public void IsValid_TestCase_1()
    {
        // Arrange
        string s = "()";

        ValidParenthesesProblem validParenthesesProblem = new ValidParenthesesProblem();

        // Act/Assert
        validParenthesesProblem.IsValid(s).Should().BeTrue();
    }

    [Fact]
    public void IsValid_TestCase_2()
    {
        // Arrange
        string s = "()[]{}";

        ValidParenthesesProblem validParenthesesProblem = new ValidParenthesesProblem();

        // Act/Assert
        validParenthesesProblem.IsValid(s).Should().BeTrue();
    }

    [Fact]
    public void IsValid_TestCase_3()
    {
        // Arrange
        string s = "(]";

        ValidParenthesesProblem validParenthesesProblem = new ValidParenthesesProblem();

        // Act/Assert
        validParenthesesProblem.IsValid(s).Should().BeTrue();
    }

    [Fact]
    public void IsValid_TestCase_4()
    {
        // Arrange
        string s = "([])";

        ValidParenthesesProblem validParenthesesProblem = new ValidParenthesesProblem();

        // Act/Assert
        validParenthesesProblem.IsValid(s).Should().BeTrue();
    }
}