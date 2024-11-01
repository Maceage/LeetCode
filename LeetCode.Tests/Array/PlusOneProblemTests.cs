using FluentAssertions;
using LeetCode.Problems.Array;

namespace LeetCode.Tests.Array;

public class PlusOneProblemTests
{
    [Fact]
    public void PlusOne_TestCase_1()
    {
        // Arrange
        int[] digits = [1, 2, 3];

        PlusOneProblem plusOneProblem = new PlusOneProblem();

        // Act
        int[] actual = plusOneProblem.PlusOne(digits);

        // Assert
        actual.Should().BeEquivalentTo([1, 2, 4], options => options.WithStrictOrdering());
    }

    [Fact]
    public void PlusOne_TestCase_2()
    {
        // Arrange
        int[] digits = [4, 3, 2, 1];

        PlusOneProblem plusOneProblem = new PlusOneProblem();

        // Act
        int[] actual = plusOneProblem.PlusOne(digits);

        // Assert
        actual.Should().BeEquivalentTo([4, 3, 2, 2], options => options.WithStrictOrdering());
    }

    [Fact]
    public void PlusOne_TestCase_3()
    {
        // Arrange
        int[] digits = [9];

        PlusOneProblem plusOneProblem = new PlusOneProblem();

        // Act
        int[] actual = plusOneProblem.PlusOne(digits);

        // Assert
        actual.Should().BeEquivalentTo([1, 0], options => options.WithStrictOrdering());
    }

    [Fact]
    public void PlusOne_TestCase_4()
    {
        // Arrange
        int[] digits = [9, 9];

        PlusOneProblem plusOneProblem = new PlusOneProblem();

        // Act
        int[] actual = plusOneProblem.PlusOne(digits);

        // Assert
        actual.Should().BeEquivalentTo([1, 0, 0], options => options.WithStrictOrdering());
    }
}