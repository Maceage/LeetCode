using FluentAssertions;
using LeetCode.Problems.Stack;

namespace LeetCode.Tests.Stack;

public class AsteroidCollisionProblemTests
{
    [Fact]
    public void AsteroidCollision_TestCase_1()
    {
        // Arrange
        int[] asteroids = [5, 10, -5];
        int[] expected = [5, 10];

        AsteroidCollisionProblem asteroidCollisionProblem = new AsteroidCollisionProblem();

        // Act
        int[] actual = asteroidCollisionProblem.AsteroidCollision(asteroids);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void AsteroidCollision_TestCase_2()
    {
        // Arrange
        int[] asteroids = [8, -8];
        int[] expected = [];

        AsteroidCollisionProblem asteroidCollisionProblem = new AsteroidCollisionProblem();

        // Act
        int[] actual = asteroidCollisionProblem.AsteroidCollision(asteroids);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void AsteroidCollision_TestCase_3()
    {
        // Arrange
        int[] asteroids = [10, 2, -5];
        int[] expected = [10];

        AsteroidCollisionProblem asteroidCollisionProblem = new AsteroidCollisionProblem();

        // Act
        int[] actual = asteroidCollisionProblem.AsteroidCollision(asteroids);

        // Assert
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
}