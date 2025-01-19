using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class MinimumIndexSumOfTwoListsProblemTests
{
    [Fact]
    public void FindRestaurant_TestCase_1()
    {
        // Arrange
        string[] list1 = ["Shogun", "Tapioca Express", "Burger King", "KFC"];
        string[] list2 = ["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"];

        MinimumIndexSumOfTwoListsProblem minimumIndexSumOfTwoListsProblem = new MinimumIndexSumOfTwoListsProblem();

        // Act
        string[] actual = minimumIndexSumOfTwoListsProblem.FindRestaurant(list1, list2);

        // Assert
        actual.Should().BeEquivalentTo("Shogun");
    }

    [Fact]
    public void FindRestaurant_TestCase_2()
    {
        // Arrange
        string[] list1 = ["Shogun", "Tapioca Express", "Burger King", "KFC"];
        string[] list2 = ["KFC", "Shogun", "Burger King"];

        MinimumIndexSumOfTwoListsProblem minimumIndexSumOfTwoListsProblem = new MinimumIndexSumOfTwoListsProblem();

        // Act
        string[] actual = minimumIndexSumOfTwoListsProblem.FindRestaurant(list1, list2);

        // Assert
        actual.Should().BeEquivalentTo("Shogun");
    }

    [Fact]
    public void FindRestaurant_TestCase_3()
    {
        // Arrange
        string[] list1 = ["happy", "sad", "good"];
        string[] list2 = ["sad", "happy", "good"];

        MinimumIndexSumOfTwoListsProblem minimumIndexSumOfTwoListsProblem = new MinimumIndexSumOfTwoListsProblem();

        // Act
        string[] actual = minimumIndexSumOfTwoListsProblem.FindRestaurant(list1, list2);

        // Assert
        actual.Should().BeEquivalentTo("sad", "happy");
    }
}