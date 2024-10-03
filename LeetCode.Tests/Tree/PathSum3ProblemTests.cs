using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class PathSum3ProblemTests
{
    [Fact]
    public void PathSum_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [10, 5, -3, 3, 2, null, 11, 3, -2, null, 1];

        TreeNode rootNode = numberArray.CreateTree();

        int targetSum = 8;

        PathSum3Problem pathSum3Problem = new PathSum3Problem();

        // Act
        int actual = pathSum3Problem.PathSum(rootNode, targetSum);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void PathSum_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1];

        TreeNode rootNode = numberArray.CreateTree();

        int targetSum = 22;

        PathSum3Problem pathSum3Problem = new PathSum3Problem();

        // Act
        int actual = pathSum3Problem.PathSum(rootNode, targetSum);

        // Assert
        actual.Should().Be(3);
    }
}