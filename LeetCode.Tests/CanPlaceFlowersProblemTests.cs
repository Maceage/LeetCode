using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class CanPlaceFlowersProblemTests
{
    [Fact]
    public void CanPlaceFlowersProblem_TestCase_1()
    {
        // Arrange
        int[] flowerBed = [1, 0, 0, 0, 1];
        int index = 1;

        CanPlaceFlowersProblem canPlaceFlowersProblem = new CanPlaceFlowersProblem();

        // Act
        bool actual = canPlaceFlowersProblem.CanPlaceFlowers(flowerBed, index);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void CanPlaceFlowersProblem_TestCase_2()
    {
        // Arrange
        int[] flowerBed = [1, 0, 0, 0, 1];
        int index = 2;

        CanPlaceFlowersProblem canPlaceFlowersProblem = new CanPlaceFlowersProblem();

        // Act
        bool actual = canPlaceFlowersProblem.CanPlaceFlowers(flowerBed, index);

        // Assert
        actual.Should().BeFalse();
    }
}