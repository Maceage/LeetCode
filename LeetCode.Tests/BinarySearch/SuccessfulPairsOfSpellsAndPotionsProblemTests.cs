using FluentAssertions;
using LeetCode.Problems.BinarySearch;

namespace LeetCode.Tests.BinarySearch;

public class SuccessfulPairsOfSpellsAndPotionsProblemTests
{
    [Fact]
    public void SuccessfulPairs_TestCase_1()
    {
        // Arrange
        int[] spells = [5, 1, 3];
        int[] potions = [1, 2, 3, 4, 5];
        int success = 7;

        SuccessfulPairsOfSpellsAndPotionsProblem successfulPairsOfSpellsAndPotionsProblem = new SuccessfulPairsOfSpellsAndPotionsProblem();

        // Act
        int[] actual = successfulPairsOfSpellsAndPotionsProblem.SuccessfulPairs(spells, potions, success);

        // Assert
        actual.Should().BeEquivalentTo([4, 0, 3], options => options.WithStrictOrdering());
    }

    [Fact]
    public void SuccessfulPairs_TestCase_2()
    {
        // Arrange
        int[] spells = [3, 1, 2];
        int[] potions = [8, 5, 8];
        int success = 16;

        SuccessfulPairsOfSpellsAndPotionsProblem successfulPairsOfSpellsAndPotionsProblem = new SuccessfulPairsOfSpellsAndPotionsProblem();

        // Act
        int[] actual = successfulPairsOfSpellsAndPotionsProblem.SuccessfulPairs(spells, potions, success);

        // Assert
        actual.Should().BeEquivalentTo([2, 0, 2], options => options.WithStrictOrdering());
    }
}