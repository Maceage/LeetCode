using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class IntersectionOfTwoArraysProblemTests
{
    [Fact]
    public void Intersection_TestCase_1()
    {
        // Arrange
        int[] nums1 = [1, 2, 2, 1];
        int[] nums2 = [2, 2];

        IntersectionOfTwoArraysProblem intersectionOfTwoArraysProblem = new IntersectionOfTwoArraysProblem();

        // Act
        int[] actual = intersectionOfTwoArraysProblem.Intersection(nums1, nums2);

        // Assert
        actual.Should().BeEquivalentTo([2]);
    }

    [Fact]
    public void Intersection_TestCase_2()
    {
        // Arrange
        int[] nums1 = [4, 9, 5];
        int[] nums2 = [9, 4, 9, 8, 4];

        IntersectionOfTwoArraysProblem intersectionOfTwoArraysProblem = new IntersectionOfTwoArraysProblem();

        // Act
        int[] actual = intersectionOfTwoArraysProblem.Intersection(nums1, nums2);

        // Assert
        actual.Should().BeEquivalentTo([9, 4]);
    }
}