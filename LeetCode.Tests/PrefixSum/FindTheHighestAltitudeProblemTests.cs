using FluentAssertions;
using LeetCode.Problems.PrefixSum;

namespace LeetCode.Tests.PrefixSum;

public class FindTheHighestAltitudeProblemTests
{
    [Fact]
    public void LargestAltitude_TestCase_1()
    {
        // Arrange
        int[] gain = [-5, 1, 5, 0, -7];

        FindTheHighestAltitudeProblem findTheHighestAltitudeProblem = new FindTheHighestAltitudeProblem();

        // Act
        int actual = findTheHighestAltitudeProblem.LargestAltitude(gain);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void LargestAltitude_TestCase_2()
    {
        // Arrange
        int[] gain = [-4, -3, -2, -1, 4, 3, 2];

        FindTheHighestAltitudeProblem findTheHighestAltitudeProblem = new FindTheHighestAltitudeProblem();

        // Act
        int actual = findTheHighestAltitudeProblem.LargestAltitude(gain);

        // Assert
        actual.Should().Be(0);
    }
}