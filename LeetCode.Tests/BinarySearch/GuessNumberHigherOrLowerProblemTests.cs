using FluentAssertions;
using LeetCode.Problems.BinarySearch;

namespace LeetCode.Tests.BinarySearch;

public class GuessNumberHigherOrLowerProblemTests
{
    [Fact]
    public void GuessNumber_TestCase_1()
    {
        // Arrange
        int n = 10;

        GuessNumberHigherOrLowerProblem guessNumberHigherOrLowerProblem = new GuessNumberHigherOrLowerProblem();
        guessNumberHigherOrLowerProblem.PickedNumber = 6;

        // Act
        int actual = guessNumberHigherOrLowerProblem.GuessNumber(n);

        // Assert
        actual.Should().Be(6);
    }

    [Fact]
    public void GuessNumber_TestCase_2()
    {
        // Arrange
        int n = 1;

        GuessNumberHigherOrLowerProblem guessNumberHigherOrLowerProblem = new GuessNumberHigherOrLowerProblem();
        guessNumberHigherOrLowerProblem.PickedNumber = 1;

        // Act
        int actual = guessNumberHigherOrLowerProblem.GuessNumber(n);

        // Assert
        actual.Should().Be(1);
    }

    [Fact]
    public void GuessNumber_TestCase_3()
    {
        // Arrange
        int n = 2;

        GuessNumberHigherOrLowerProblem guessNumberHigherOrLowerProblem = new GuessNumberHigherOrLowerProblem();
        guessNumberHigherOrLowerProblem.PickedNumber = 1;

        // Act
        int actual = guessNumberHigherOrLowerProblem.GuessNumber(n);

        // Assert
        actual.Should().Be(1);
    }
}