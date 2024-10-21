using FluentAssertions;
using LeetCode.Problems.DynamicProgramming;

namespace LeetCode.Tests.DynamicProgramming;

public class EditDistanceProblemTests
{
    [Fact]
    public void MinDistance_TestCase_1()
    {
        // Arrange
        string word1 = "horse";
        string word2 = "ros";

        EditDistanceProblem editDistanceProblem = new EditDistanceProblem();

        // Act
        int actual = editDistanceProblem.MinDistance(word1, word2);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void MinDistance_TestCase_2()
    {
        // Arrange
        string word1 = "intention";
        string word2 = "execution";

        EditDistanceProblem editDistanceProblem = new EditDistanceProblem();

        // Act
        int actual = editDistanceProblem.MinDistance(word1, word2);

        // Assert
        actual.Should().Be(5);
    }
}