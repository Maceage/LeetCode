using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class FindTheDifferenceOfTwoArraysProblemTests
{
    [Fact]
    public void FindDifference_TestCase_1()
    {
        // Arrange
        int[] nums1 = [1, 2, 3];
        int[] nums2 = [2, 4, 6];

        FindTheDifferenceOfTwoArraysProblem findTheDifferenceOfTwoArraysProblem = new FindTheDifferenceOfTwoArraysProblem();

        // Act
        IList<IList<int>> actual = findTheDifferenceOfTwoArraysProblem.FindDifference(nums1, nums2);

        // Assert
        List<List<int>> expected =
        [
            new() { 1, 3 },
            new() { 4, 6 }
        ];

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void FindDifference_TestCase_2()
    {
        // Arrange
        int[] nums1 = [1, 2, 3, 3];
        int[] nums2 = [1, 1, 2, 2];

        FindTheDifferenceOfTwoArraysProblem findTheDifferenceOfTwoArraysProblem = new FindTheDifferenceOfTwoArraysProblem();

        // Act
        IList<IList<int>> actual = findTheDifferenceOfTwoArraysProblem.FindDifference(nums1, nums2);

        // Assert
        List<List<int>> expected =
        [
            new() { 3 },
            new() {}
        ];

        actual.Should().BeEquivalentTo(expected);
    }
}