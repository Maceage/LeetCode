using FluentAssertions;
using LeetCode.Problems;

namespace LeetCode.Tests;

public class ProductOfArrayExceptSelfProblemTests
{
    [Fact]
    public void ProductExceptSelf_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4];
        int[] expected = [24, 12, 8, 6];

        ProductOfArrayExceptSelfProblem productOfArrayExceptSelf = new ProductOfArrayExceptSelfProblem();

        // Act
        int[] actual = productOfArrayExceptSelf.ProductExceptSelf(nums);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ProductExceptSelf_TestCase_2()
    {
        // Arrange
        int[] nums = [-1, 1, 0, -3, 3];
        int[] expected = [0, 0, 9, 0, 0];

        ProductOfArrayExceptSelfProblem productOfArrayExceptSelf = new ProductOfArrayExceptSelfProblem();

        // Act
        int[] actual = productOfArrayExceptSelf.ProductExceptSelf(nums);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
}