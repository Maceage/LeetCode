using FluentAssertions;
using LeetCode.Problems.BinarySearch;

namespace LeetCode.Tests.BinarySearch;

public class KokoEatingBananasProblemTests
{
    [Fact]
    public void MinEatingSpeed_TestCase_1()
    {
        // Arrange
        int[] piles = [3, 6, 7, 11];
        int h = 8;

        KokoEatingBananasProblem kokoEatingBananasProblem = new KokoEatingBananasProblem();

        // Act
        int actual = kokoEatingBananasProblem.MinEatingSpeed(piles, h);

        // Assert
        actual.Should().Be(4);
    }

    [Fact]
    public void MinEatingSpeed_TestCase_2()
    {
        // Arrange
        int[] piles = [30, 11, 23, 4, 20];
        int h = 5;

        KokoEatingBananasProblem kokoEatingBananasProblem = new KokoEatingBananasProblem();

        // Act
        int actual = kokoEatingBananasProblem.MinEatingSpeed(piles, h);

        // Assert
        actual.Should().Be(30);
    }

    [Fact]
    public void MinEatingSpeed_TestCase_3()
    {
        // Arrange
        int[] piles = [30, 11, 23, 4, 20];
        int h = 6;

        KokoEatingBananasProblem kokoEatingBananasProblem = new KokoEatingBananasProblem();

        // Act
        int actual = kokoEatingBananasProblem.MinEatingSpeed(piles, h);

        // Assert
        actual.Should().Be(23);
    }
}