using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class ContainsDuplicateProblemTests
{
    [Fact]
    public void ContainsDuplicate_TestCase_1()
    {
        // Arrange
        int[] nums = [1, 2, 3, 1];

        ContainsDuplicateProblem containsDuplicateProblem = new ContainsDuplicateProblem();

        // Act
        bool actual = containsDuplicateProblem.ContainsDuplicate(nums);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void ContainsDuplicate_TestCase_2()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4];

        ContainsDuplicateProblem containsDuplicateProblem = new ContainsDuplicateProblem();

        // Act
        bool actual = containsDuplicateProblem.ContainsDuplicate(nums);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void ContainsDuplicate_TestCase_3()
    {
        // Arrange
        int[] nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];

        ContainsDuplicateProblem containsDuplicateProblem = new ContainsDuplicateProblem();

        // Act
        bool actual = containsDuplicateProblem.ContainsDuplicate(nums);

        // Assert
        actual.Should().BeTrue();
    }
}