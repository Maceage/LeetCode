using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class IsomorphicStringsProblemTests
{
    [Fact]
    public void IsIsomorphic_TestCase_1()
    {
        // Arrange
        string s = "egg";
        string t = "add";

        IsomorphicStringsProblem isomorphicStringsProblem = new IsomorphicStringsProblem();

        // Act
        bool actual = isomorphicStringsProblem.IsIsomorphic(s, t);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void IsIsomorphic_TestCase_2()
    {
        // Arrange
        string s = "foo";
        string t = "bar";

        IsomorphicStringsProblem isomorphicStringsProblem = new IsomorphicStringsProblem();

        // Act
        bool actual = isomorphicStringsProblem.IsIsomorphic(s, t);

        actual.Should().BeFalse();
    }

    [Fact]
    public void IsIsomorphic_TestCase_3()
    {
        // Arrange
        string s = "paper";
        string t = "title";

        IsomorphicStringsProblem isomorphicStringsProblem = new IsomorphicStringsProblem();

        // Act
        bool actual = isomorphicStringsProblem.IsIsomorphic(s, t);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void IsIsomorphic_TestCase_4()
    {
        // Arrange
        string s = "a";
        string t = "a";

        IsomorphicStringsProblem isomorphicStringsProblem = new IsomorphicStringsProblem();

        // Act
        bool actual = isomorphicStringsProblem.IsIsomorphic(s, t);

        // Assert
        actual.Should().BeTrue();
    }
}