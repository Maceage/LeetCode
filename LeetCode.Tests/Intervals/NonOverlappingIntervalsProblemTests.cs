using FluentAssertions;
using LeetCode.Problems.Intervals;

namespace LeetCode.Tests.Intervals;

public class NonOverlappingIntervalsProblemTests
{
    [Fact]
    public void EraseOverlapInterval_TestCase_1()
    {
        // Arrange
        int[][] intervals = [[1, 2], [2, 3], [3, 4], [1, 3]];

        NonOverlappingIntervalsProblem nonOverlappingIntervalsProblem = new NonOverlappingIntervalsProblem();

        // Act
        int actual = nonOverlappingIntervalsProblem.EraseOverlapIntervals(intervals);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void EraseOverlapInterval_TestCase_2()
    {
        // Arrange
        int[][] intervals = [[1, 2], [1, 2], [1, 2]];

        NonOverlappingIntervalsProblem nonOverlappingIntervalsProblem = new NonOverlappingIntervalsProblem();

        // Act
        int actual = nonOverlappingIntervalsProblem.EraseOverlapIntervals(intervals);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]
    public void EraseOverlapInterval_TestCase_3()
    {
        // Arrange
        int[][] intervals = [[1, 2], [2, 3]];

        NonOverlappingIntervalsProblem nonOverlappingIntervalsProblem = new NonOverlappingIntervalsProblem();

        // Act
        int actual = nonOverlappingIntervalsProblem.EraseOverlapIntervals(intervals);

        // Assert
        actual.Should().Be(0);
    }
}