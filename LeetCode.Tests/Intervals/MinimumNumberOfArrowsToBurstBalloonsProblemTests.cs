using FluentAssertions;
using LeetCode.Problems.Intervals;

namespace LeetCode.Tests.Intervals;

public class MinimumNumberOfArrowsToBurstBalloonsProblemTests
{
    [Fact]
    public void FindMinArrowShots_TestCase_1()
    {
        // Arrange
        int[][] points = [[10, 16], [2, 8], [1, 6], [7, 12]];

        MinimumNumberOfArrowsToBurstBalloonsProblem minimumNumberOfArrowsToBurstBalloonsProblem = new MinimumNumberOfArrowsToBurstBalloonsProblem();

        // Act
        int actual = minimumNumberOfArrowsToBurstBalloonsProblem.FindMinArrowShots(points);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void FindMinArrowShots_TestCase_2()
    {
        // Arrange
        int[][] points = [[1, 2], [3, 4], [5, 6], [7, 8]];

        MinimumNumberOfArrowsToBurstBalloonsProblem minimumNumberOfArrowsToBurstBalloonsProblem = new MinimumNumberOfArrowsToBurstBalloonsProblem();

        // Act
        int actual = minimumNumberOfArrowsToBurstBalloonsProblem.FindMinArrowShots(points);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void FindMinArrowShots_TestCase_3()
    {
        // Arrange
        int[][] points = [[1, 2], [2, 3], [3, 4], [4, 5]];

        MinimumNumberOfArrowsToBurstBalloonsProblem minimumNumberOfArrowsToBurstBalloonsProblem = new MinimumNumberOfArrowsToBurstBalloonsProblem();

        // Act
        int actual = minimumNumberOfArrowsToBurstBalloonsProblem.FindMinArrowShots(points);

        // Assert
        actual.Should().Be(2);
    }
}