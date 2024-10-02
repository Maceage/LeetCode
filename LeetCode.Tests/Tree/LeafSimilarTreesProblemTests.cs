using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.Tree;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Tree;

public class LeafSimilarTreesProblemTests
{
    [Fact]
    public void LeafSimilar_TestCase_1()
    {
        // Arrange
        int?[] numberArray1 = [3, 5, 1, 6, 2, 9, 8, null, null, 7, 4];
        int?[] numberArray2 = [3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8];

        TreeNode root1 = numberArray1.CreateTree();
        TreeNode root2 = numberArray2.CreateTree();

        LeafSimilarTreesProblem leafSimilarTreesProblem = new LeafSimilarTreesProblem();

        // Act
        bool actual = leafSimilarTreesProblem.LeafSimilar(root1, root2);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void LeafSimilar_TestCase_2()
    {
        // Arrange
        int?[] numberArray1 = [1, 2, 3];
        int?[] numberArray2 = [1, 3, 2];

        TreeNode root1 = numberArray1.CreateTree();
        TreeNode root2 = numberArray2.CreateTree();

        LeafSimilarTreesProblem leafSimilarTreesProblem = new LeafSimilarTreesProblem();

        // Act
        bool actual = leafSimilarTreesProblem.LeafSimilar(root1, root2);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void LeafSimilar_TestCase_3()
    {
        // Arrange
        int?[] numberArray1 = [3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 11, null, null, 8, 10];
        int?[] numberArray2 = [3, 5, 1, 6, 2, 9, 8, null, null, 7, 4];

        TreeNode root1 = numberArray1.CreateTree();
        TreeNode root2 = numberArray2.CreateTree();

        LeafSimilarTreesProblem leafSimilarTreesProblem = new LeafSimilarTreesProblem();

        // Act
        bool actual = leafSimilarTreesProblem.LeafSimilar(root1, root2);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void LeafSimilar_TestCase_4()
    {
        // Arrange
        int?[] numberArray1 = [3, 5, 1, 6, 2, 9, 8, null, null, 7, 14];
        int?[] numberArray2 = [3, 5, 1, 6, 71, 4, 2, null, null, null, null, null, null, 9, 8];

        TreeNode root1 = numberArray1.CreateTree();
        TreeNode root2 = numberArray2.CreateTree();

        LeafSimilarTreesProblem leafSimilarTreesProblem = new LeafSimilarTreesProblem();

        // Act
        bool actual = leafSimilarTreesProblem.LeafSimilar(root1, root2);

        // Assert
        actual.Should().BeFalse();
    }
}