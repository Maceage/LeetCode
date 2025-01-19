using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class IntersectionOfTwoArrays2ProblemTests
{
    [Fact]
    public void Intersect_TestCase_1()
    {
        // Arrange
        int[] nums1 = [1, 2, 2, 1];
        int[] nums2 = [2, 2];

        IntersectionOfTwoArrays2Problem intersectionOfTwoArrays2Problem = new IntersectionOfTwoArrays2Problem();

        // Act
        int[] actual = intersectionOfTwoArrays2Problem.Intersect(nums1, nums2);

        // Assert
        actual.Should().BeEquivalentTo([2, 2]);
    }

    [Fact]
    public void Intersect_TestCase_2()
    {
        // Arrange
        int[] nums1 = [4, 9, 5];
        int[] nums2 = [9, 4, 9, 8, 4];

        IntersectionOfTwoArrays2Problem intersectionOfTwoArrays2Problem = new IntersectionOfTwoArrays2Problem();

        // Act
        int[] actual = intersectionOfTwoArrays2Problem.Intersect(nums1, nums2);

        // Assert
        actual.Should().BeEquivalentTo([9, 4]);
    }
}