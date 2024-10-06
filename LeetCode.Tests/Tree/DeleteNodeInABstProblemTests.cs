using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class DeleteNodeInABstProblemTests
{
    [Fact]
    public void DeleteNode_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [5, 3, 6, 2, 4, null, 7];
        int key = 3;

        TreeNode rootNode = numberArray.CreateTree();

        DeleteNodeInABstProblem deleteNodeInABstProblem = new DeleteNodeInABstProblem();

        // Act
        TreeNode actual = deleteNodeInABstProblem.DeleteNode(rootNode, key);

        // Assert
        int?[] result = actual.GetNodeValues();

        result.Should().BeEquivalentTo([5, 4, 6, 2, (int?)null, null, 7], options => options.WithStrictOrdering());
    }

    [Fact]
    public void DeleteNode_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [5, 3, 6, 2, 4, null, 7];
        int key = 0;

        TreeNode rootNode = numberArray.CreateTree();

        DeleteNodeInABstProblem deleteNodeInABstProblem = new DeleteNodeInABstProblem();

        // Act
        TreeNode actual = deleteNodeInABstProblem.DeleteNode(rootNode, key);

        // Assert
        int?[] result = actual.GetNodeValues();

        result.Should().BeEquivalentTo([5, 3, 6, 2, 4, (int?)null, 7], options => options.WithStrictOrdering());
    }

    [Fact]
    public void DeleteNode_TestCase_3()
    {
        // Arrange
        int?[] numberArray = [];
        int key = 0;

        TreeNode rootNode = numberArray.CreateTree();

        DeleteNodeInABstProblem deleteNodeInABstProblem = new DeleteNodeInABstProblem();

        // Act
        TreeNode actual = deleteNodeInABstProblem.DeleteNode(rootNode, key);

        // Assert
        int?[] result = actual.GetNodeValues();

        result.Should().BeEquivalentTo(new int?[] { }, options => options.WithStrictOrdering());
    }

    [Fact]
    public void DeleteNode_TestCase_4()
    {
        // Arrange
        int?[] numberArray = [0];
        int key = 0;

        TreeNode rootNode = numberArray.CreateTree();

        DeleteNodeInABstProblem deleteNodeInABstProblem = new DeleteNodeInABstProblem();

        // Act
        TreeNode actual = deleteNodeInABstProblem.DeleteNode(rootNode, key);

        // Assert
        int?[] result = actual.GetNodeValues();

        result.Should().BeEquivalentTo(new int?[] { }, options => options.WithStrictOrdering());
    }

    [Fact]
    public void DeleteNode_TestCase_5()
    {
        // Arrange
        int?[] numberArray = [5, 3, 6, 2, 4, null, 7];
        int key = 5;

        TreeNode rootNode = numberArray.CreateTree();

        DeleteNodeInABstProblem deleteNodeInABstProblem = new DeleteNodeInABstProblem();

        // Act
        TreeNode actual = deleteNodeInABstProblem.DeleteNode(rootNode, key);

        // Assert
        int?[] result = actual.GetNodeValues();

        result.Should().BeEquivalentTo([6, 3, 7, 2, 4], options => options.WithStrictOrdering());
    }
}