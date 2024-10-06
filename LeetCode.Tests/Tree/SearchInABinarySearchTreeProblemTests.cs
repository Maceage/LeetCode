using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class SearchInABinarySearchTreeProblemTests
{
    [Fact]
    public void SearchBST_TestCase_1()
    {
        // Arrange
        int?[] numberArray = [4, 2, 7, 1, 3];
        int value = 2;

        TreeNode rootNode = numberArray.CreateTree();

        SearchInABinarySearchTreeProblem searchInABinarySearchTreeProblem = new SearchInABinarySearchTreeProblem();

        // Act
        TreeNode actual = searchInABinarySearchTreeProblem.SearchBST(rootNode, value);

        // Assert
        int?[] nodeValues = actual.GetNodeValues();

        nodeValues.Should().BeEquivalentTo([2, 1, 3], options => options.WithStrictOrdering());
    }

    [Fact]
    public void SearchBST_TestCase_2()
    {
        // Arrange
        int?[] numberArray = [4, 2, 7, 1, 3];
        int value = 5;

        TreeNode rootNode = numberArray.CreateTree();

        SearchInABinarySearchTreeProblem searchInABinarySearchTreeProblem = new SearchInABinarySearchTreeProblem();

        // Act
        TreeNode actual = searchInABinarySearchTreeProblem.SearchBST(rootNode, value);

        // Assert
        int?[] nodeValues = actual.GetNodeValues();

        nodeValues.Should().BeEquivalentTo(new int[] { }, options => options.WithStrictOrdering());
    }

    [Fact]
    public void SearchBST_TestCase_3()
    {
        // Arrange
        int?[] numberArray = [18, 2, 22, null, null, null, 63, null, 84, null, null];
        int value = 63;

        TreeNode rootNode = numberArray.CreateTree();

        SearchInABinarySearchTreeProblem searchInABinarySearchTreeProblem = new SearchInABinarySearchTreeProblem();

        // Act
        TreeNode actual = searchInABinarySearchTreeProblem.SearchBST(rootNode, value);

        // Assert
        int?[] nodeValues = actual.GetNodeValues();

        nodeValues.Should().BeEquivalentTo([63, (int?)null, 84], options => options.WithStrictOrdering());
    }

    [Fact]
    public void SearchBST_TestCase_4()
    {
        // Arrange
        int?[] numberArray = [62, 2, 93, null, 30, null, null, 15, null, null, null];
        int value = 15;

        TreeNode rootNode = numberArray.CreateTree();

        SearchInABinarySearchTreeProblem searchInABinarySearchTreeProblem = new SearchInABinarySearchTreeProblem();

        // Act
        TreeNode actual = searchInABinarySearchTreeProblem.SearchBST(rootNode, value);

        // Assert
        int?[] nodeValues = actual.GetNodeValues();

        nodeValues.Should().BeEquivalentTo([15], options => options.WithStrictOrdering());
    }
}