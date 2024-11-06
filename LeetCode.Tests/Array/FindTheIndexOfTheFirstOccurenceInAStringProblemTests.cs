using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class FindTheIndexOfTheFirstOccurenceInAStringProblemTests
{
    [Fact]
    public void StrStr_TestCase_1()
    {
        // Arrange
        string haystack = "sadbutsad";
        string needle = "sad";

        FindTheIndexOfTheFirstOccurenceInAStringProblem findTheIndexOfTheFirstOccurenceInAStringProblem = new FindTheIndexOfTheFirstOccurenceInAStringProblem();

        // Act
        int actual = findTheIndexOfTheFirstOccurenceInAStringProblem.StrStr(haystack, needle);

        // Assert
        actual.Should().Be(0);
    }

    [Fact]
    public void StrStr_TestCase_2()
    {
        // Arrange
        string haystack = "leetcode";
        string needle = "leeto";

        FindTheIndexOfTheFirstOccurenceInAStringProblem findTheIndexOfTheFirstOccurenceInAStringProblem = new FindTheIndexOfTheFirstOccurenceInAStringProblem();

        // Act
        int actual = findTheIndexOfTheFirstOccurenceInAStringProblem.StrStr(haystack, needle);

        // Assert
        actual.Should().Be(-1);
    }

    [Fact]
    public void StrStr_TestCase_3()
    {
        // Arrange
        string haystack = "mississippi";
        string needle = "issip";

        FindTheIndexOfTheFirstOccurenceInAStringProblem findTheIndexOfTheFirstOccurenceInAStringProblem = new FindTheIndexOfTheFirstOccurenceInAStringProblem();

        // Act
        int actual = findTheIndexOfTheFirstOccurenceInAStringProblem.StrStr(haystack, needle);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void StrStr_TestCase_4()
    {
        // Arrange
        string haystack = "aaaaa";
        string needle = "bba";

        FindTheIndexOfTheFirstOccurenceInAStringProblem findTheIndexOfTheFirstOccurenceInAStringProblem = new FindTheIndexOfTheFirstOccurenceInAStringProblem();

        // Act
        int actual = findTheIndexOfTheFirstOccurenceInAStringProblem.StrStr(haystack, needle);

        // Assert
        actual.Should().Be(-1);
    }
}