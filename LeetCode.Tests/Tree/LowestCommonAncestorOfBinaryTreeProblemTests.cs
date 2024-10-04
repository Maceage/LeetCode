using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class LowestCommonAncestorOfBinaryTreeProblemTests
{
    [Fact]
    public void LowestCommonAncestor_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4];

        TreeNode rootNode = numberArray.CreateTree();

        TreeNode p = rootNode.FindNodeWithValue(5);
        TreeNode q = rootNode.FindNodeWithValue(1);

        TreeNode expected = rootNode.FindNodeWithValue(3);

        LowestCommonAncestorOfBinaryTreeProblem lowestCommonAncestorOfBinaryTreeProblem = new LowestCommonAncestorOfBinaryTreeProblem();

        // Act
        TreeNode actual = lowestCommonAncestorOfBinaryTreeProblem.LowestCommonAncestor(rootNode, p, q);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void LowestCommonAncestor_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4];

        TreeNode rootNode = numberArray.CreateTree();

        TreeNode p = rootNode.FindNodeWithValue(5);
        TreeNode q = rootNode.FindNodeWithValue(4);

        TreeNode expected = rootNode.FindNodeWithValue(5);

        LowestCommonAncestorOfBinaryTreeProblem lowestCommonAncestorOfBinaryTreeProblem = new LowestCommonAncestorOfBinaryTreeProblem();

        // Act
        TreeNode actual = lowestCommonAncestorOfBinaryTreeProblem.LowestCommonAncestor(rootNode, p, q);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void LowestCommonAncestor_TestCase_3()
    {
        // Arrange
        int?[] numberArray = [1, 2];

        TreeNode rootNode = numberArray.CreateTree();

        TreeNode p = rootNode.FindNodeWithValue(1);
        TreeNode q = rootNode.FindNodeWithValue(2);

        TreeNode expected = rootNode.FindNodeWithValue(1);

        LowestCommonAncestorOfBinaryTreeProblem lowestCommonAncestorOfBinaryTreeProblem = new LowestCommonAncestorOfBinaryTreeProblem();

        // Act
        TreeNode actual = lowestCommonAncestorOfBinaryTreeProblem.LowestCommonAncestor(rootNode, p, q);

        // Assert
        actual.Should().Be(expected);
    }
}