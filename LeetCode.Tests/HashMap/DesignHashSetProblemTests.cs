using FluentAssertions;
using LeetCode.Problems.HashMap;

namespace LeetCode.Tests.HashMap;

public class DesignHashSetProblemTests
{
    [Fact]
    public void MyHashSetWithLinkedList_TestCase_1()
    {
        // Arrange
        DesignHashSetProblem.MyHashSetWithLinkedList myHashSetWithLinkedList = new DesignHashSetProblem.MyHashSetWithLinkedList();

        // Act/Assert
        myHashSetWithLinkedList.Add(1);
        myHashSetWithLinkedList.Add(2);
        myHashSetWithLinkedList.Contains(1).Should().BeTrue();
        myHashSetWithLinkedList.Contains(3).Should().BeFalse();
        myHashSetWithLinkedList.Add(3);
        myHashSetWithLinkedList.Contains(2).Should().BeTrue();
        myHashSetWithLinkedList.Remove(2);
        myHashSetWithLinkedList.Contains(2).Should().BeFalse();
    }

    [Fact]
    public void MyHashSetWithBinarySearchTree_TestCase_1()
    {
        // Arrange
        DesignHashSetProblem.MyHashSetWithBinarySearchTree hashSetWithBinarySearchTree = new DesignHashSetProblem.MyHashSetWithBinarySearchTree();

        // Act/Assert
        hashSetWithBinarySearchTree.Add(1);
        hashSetWithBinarySearchTree.Add(2);
        hashSetWithBinarySearchTree.Contains(1).Should().BeTrue();
        hashSetWithBinarySearchTree.Contains(3).Should().BeFalse();
        hashSetWithBinarySearchTree.Add(3);
        hashSetWithBinarySearchTree.Contains(2).Should().BeTrue();
        hashSetWithBinarySearchTree.Remove(2);
        hashSetWithBinarySearchTree.Contains(2).Should().BeFalse();
    }
}