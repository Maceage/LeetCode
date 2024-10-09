using FluentAssertions;
using LeetCode.Problems.Graph;

namespace LeetCode.Tests.Graph;

public class NearestExitFromEntranceInMazeProblemTests
{
    [Fact]
    public void NearestExit_TestCase_1()
    {
        // Arrange
        char[][] maze = [['+', '+', '.', '+'], ['.', '.', '.', '+'], ['+', '+', '+', '.']];
        int[] entrance = [1, 2];

        NearestExitFromEntranceInMazeProblem nearestExitFromEntranceInMazeProblem = new NearestExitFromEntranceInMazeProblem();

        // Act
        int actual = nearestExitFromEntranceInMazeProblem.NearestExit(maze, entrance);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void NearestExit_TestCase_2()
    {
        // Arrange
        char[][] maze = [['+', '+', '+'], ['.', '.', '.'], ['+', '+', '+']];
        int[] entrance = [1, 0];

        NearestExitFromEntranceInMazeProblem nearestExitFromEntranceInMazeProblem = new NearestExitFromEntranceInMazeProblem();

        // Act
        int actual = nearestExitFromEntranceInMazeProblem.NearestExit(maze, entrance);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void NearestExit_TestCase_3()
    {
        // Arrange
        char[][] maze = [['.', '+']];
        int[] entrance = [0, 0];

        NearestExitFromEntranceInMazeProblem nearestExitFromEntranceInMazeProblem = new NearestExitFromEntranceInMazeProblem();

        // Act
        int actual = nearestExitFromEntranceInMazeProblem.NearestExit(maze, entrance);

        // Assert
        actual.Should().Be(-1);
    }
}