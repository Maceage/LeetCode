using FluentAssertions;
using LeetCode.Problems.BitManipulation;

namespace LeetCode.Tests.BitManipulation;

public class CountingBitsProblemTests
{
    [Fact]
    public void CountBits_TestCase_1()
    {
        // Arrange
        int n = 2;

        CountingBitsProblem countingBitsProblem = new CountingBitsProblem();

        // Act
        int[] actual = countingBitsProblem.CountBits(n);

        // Assert
        actual.Should().BeEquivalentTo([0, 1, 1], options => options.WithStrictOrdering());
    }

    [Fact]
    public void CountBits_TestCase_2()
    {
        // Arrange
        int n = 5;

        CountingBitsProblem countingBitsProblem = new CountingBitsProblem();

        // Act
        int[] actual = countingBitsProblem.CountBits(n);

        // Assert
        actual.Should().BeEquivalentTo([0, 1, 1, 2, 1, 2], options => options.WithStrictOrdering());
    }
}