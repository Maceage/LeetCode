using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class UniqueNumberOfOccurrencesProblemTests
{
    [Fact]
    public void UniqueOccurrences_TestCase_1()
    {
        // Arrange
        int[] arr = [1, 2, 2, 1, 1, 3];

        UniqueNumberOfOccurrencesProblem uniqueNumberOfOccurrencesProblem = new UniqueNumberOfOccurrencesProblem();

        // Act
        bool actual = uniqueNumberOfOccurrencesProblem.UniqueOccurrences(arr);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void UniqueOccurrences_TestCase_2()
    {
        // Arrange
        int[] arr = [1, 2];

        UniqueNumberOfOccurrencesProblem uniqueNumberOfOccurrencesProblem = new UniqueNumberOfOccurrencesProblem();

        // Act
        bool actual = uniqueNumberOfOccurrencesProblem.UniqueOccurrences(arr);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void UniqueOccurrences_TestCase_3()
    {
        // Arrange
        int[] arr = [-3, 0, 1, -3, 1, 1, 1, -3, 10, 0];

        UniqueNumberOfOccurrencesProblem uniqueNumberOfOccurrencesProblem = new UniqueNumberOfOccurrencesProblem();

        // Act
        bool actual = uniqueNumberOfOccurrencesProblem.UniqueOccurrences(arr);

        // Assert
        actual.Should().BeTrue();
    }
}