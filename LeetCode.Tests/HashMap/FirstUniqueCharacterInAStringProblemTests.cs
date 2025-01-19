using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class FirstUniqueCharacterInAStringProblemTests
{
    [Fact]
    public void FirstUniqueChar_TestCase_1()
    {
        // Arrange
        string s = "leetcode";

        FirstUniqueCharacterInAStringProblem firstUniqueCharacterInAStringProblem = new FirstUniqueCharacterInAStringProblem();

        // Act
        int actual = firstUniqueCharacterInAStringProblem.FirstUniqueChar(s);

        // Assert
        actual.Should().Be(0);
    }

    [Fact]
    public void FirstUniqueChar_TestCase_2()
    {
        // Arrange
        string s = "loveleetcode";

        FirstUniqueCharacterInAStringProblem firstUniqueCharacterInAStringProblem = new FirstUniqueCharacterInAStringProblem();

        // Act
        int actual = firstUniqueCharacterInAStringProblem.FirstUniqueChar(s);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void FirstUniqueChar_TestCase_3()
    {
        // Arrange
        string s = "aabb";

        FirstUniqueCharacterInAStringProblem firstUniqueCharacterInAStringProblem = new FirstUniqueCharacterInAStringProblem();

        // Act
        int actual = firstUniqueCharacterInAStringProblem.FirstUniqueChar(s);

        // Assert
        actual.Should().Be(-1);
    }
}