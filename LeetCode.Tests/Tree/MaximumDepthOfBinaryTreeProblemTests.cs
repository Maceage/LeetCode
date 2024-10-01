using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class MaximumDepthOfBinaryTreeProblemTests
{
    [Fact]
    public void MaxDepth_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [3, 9, 20, null, null, 15, 7];

        TreeNode rootNode = numberArray.CreateTree();

        MaximumDepthOfBinaryTreeProblem maximumDepthOfBinaryTreeProblem = new MaximumDepthOfBinaryTreeProblem();

        // Act
        int actual = maximumDepthOfBinaryTreeProblem.MaxDepth(rootNode);

        // Assert
        actual.Should().Be(3);
    }

    [Fact]
    public void MaxDepth_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [1, null, 2];

        TreeNode rootNode = numberArray.CreateTree();

        MaximumDepthOfBinaryTreeProblem maximumDepthOfBinaryTreeProblem = new MaximumDepthOfBinaryTreeProblem();

        // Act
        int actual = maximumDepthOfBinaryTreeProblem.MaxDepth(rootNode);

        // Assert
        actual.Should().Be(2);
    }
}