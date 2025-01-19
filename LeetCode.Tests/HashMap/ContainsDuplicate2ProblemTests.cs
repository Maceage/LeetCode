using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class ContainsDuplicate2ProblemTests
{
    [Fact]
    public void ContainsNearbyDuplicate_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 2, 3, 1];
        int k = 3;

        ContainsDuplicate2Problem containsDuplicate2Problem = new ContainsDuplicate2Problem();

        // Act
        bool actual = containsDuplicate2Problem.ContainsNearbyDuplicate(nums, k);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void ContainsNearbyDuplicate_TestCase_2()
    {
        // Arrange
        int[] nums = [1, 0, 1, 1];
        int k = 1;

        ContainsDuplicate2Problem containsDuplicate2Problem = new ContainsDuplicate2Problem();

        // Act
        bool actual = containsDuplicate2Problem.ContainsNearbyDuplicate(nums, k);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void ContainsNearbyDuplicate_TestCase_3()
    {
        // Arrange
        int[] nums = [1, 2, 3, 1, 2, 3];
        int k = 2;

        ContainsDuplicate2Problem containsDuplicate2Problem = new ContainsDuplicate2Problem();

        // Act
        bool actual = containsDuplicate2Problem.ContainsNearbyDuplicate(nums, k);

        // Assert
        actual.Should().BeFalse();
    }
}