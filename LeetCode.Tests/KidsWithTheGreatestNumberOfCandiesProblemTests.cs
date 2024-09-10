using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests
{
    public class KidsWithTheGreatestNumberOfCandiesProblemTests
    {
        [Fact]
        public void KidsWithCandies_TestCase_1()
        {
            // Arrange
            int[] candies = [2, 3, 5, 1, 3];
            int extraCandies = 3;

            bool[] expected = [true, true, true, false, true];

            KidsWithTheGreatestNumberOfCandiesProblem candiesProblem = new KidsWithTheGreatestNumberOfCandiesProblem();

            // Act
            IList<bool> actual = candiesProblem.KidsWithCandies(candies, extraCandies);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void KidsWithCandies_TestCase_2()
        {
            // Arrange
            int[] candies = [4, 2, 1, 1, 2];
            int extraCandies = 1;

            bool[] expected = [true, false, false, false, false];

            KidsWithTheGreatestNumberOfCandiesProblem candiesProblem = new KidsWithTheGreatestNumberOfCandiesProblem();

            // Act
            IList<bool> actual = candiesProblem.KidsWithCandies(candies, extraCandies);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void KidsWithCandies_TestCase_3()
        {
            // Arrange
            int[] candies = [12, 1, 12];
            int extraCandies = 10;

            bool[] expected = [true, false, true];

            KidsWithTheGreatestNumberOfCandiesProblem candiesProblem = new KidsWithTheGreatestNumberOfCandiesProblem();

            // Act
            IList<bool> actual = candiesProblem.KidsWithCandies(candies, extraCandies);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
