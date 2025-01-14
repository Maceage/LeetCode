using FluentAssertions;
using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class IntersectionOfTwoLinkedListsProblemTests
{
    [Fact]
    public void GetIntersectionNode_TestCase_1()
    {
        // Arrange
        int intersectVal = 8;

        int[] listA = [4, 1, 8, 4, 5];
        int[] listB = [5, 6, 1, 8, 4, 5];

        int skipA = 2;
        int skipB = 3;

        ListNode headA = listA.CreateLinkedList();
        ListNode headB = listB.CreateLinkedList();

        headA = MergeLinkedLists(headB, headA, skipB, skipA);

        ListNode expected = headA.GetNodeAt(skipA + 1);

        IntersectionOfTwoLinkedListsProblem intersectionOfTwoLinkedListsProblem = new IntersectionOfTwoLinkedListsProblem();

        // Act
        ListNode actual = intersectionOfTwoLinkedListsProblem.GetIntersectionNode(headA, headB);

        // Assert
        actual.Value.Should().Be(intersectVal);
        actual.Should().Be(expected);
    }

    [Fact]
    public void GetIntersectionNode_TestCase_2()
    {
        // Arrange
        int intersectVal = 2;

        int[] listA = [1, 9, 1, 2, 4];
        int[] listB = [3, 2, 4];

        int skipA = 3;
        int skipB = 1;

        ListNode headA = listA.CreateLinkedList();
        ListNode headB = listB.CreateLinkedList();

        headA = MergeLinkedLists(headB, headA, skipB, skipA);

        ListNode expected = headA.GetNodeAt(skipA + 1);

        IntersectionOfTwoLinkedListsProblem intersectionOfTwoLinkedListsProblem = new IntersectionOfTwoLinkedListsProblem();

        // Act
        ListNode actual = intersectionOfTwoLinkedListsProblem.GetIntersectionNode(headA, headB);

        // Assert
        actual.Value.Should().Be(intersectVal);
        actual.Should().Be(expected);
    }

    [Fact]
    public void GetIntersectionNode_TestCase_3()
    {
        // Arrange
        int[] listA = [2, 6, 4];
        int[] listB = [1, 5];

        int skipA = 3;
        int skipB = 2;

        ListNode headA = listA.CreateLinkedList();
        ListNode headB = listB.CreateLinkedList();

        headA = MergeLinkedLists(headB, headA, skipB, skipA);

        IntersectionOfTwoLinkedListsProblem intersectionOfTwoLinkedListsProblem = new IntersectionOfTwoLinkedListsProblem();

        // Act
        ListNode actual = intersectionOfTwoLinkedListsProblem.GetIntersectionNode(headA, headB);

        // Assert
        actual.Should().BeNull();
    }

    private static ListNode MergeLinkedLists(ListNode sourceHeadNode, ListNode targetHeadNode, int skipSource, int skipTarget)
    {
        ListNode sourceListNode = sourceHeadNode.GetNodeAt(skipSource);
        ListNode targetListNode = targetHeadNode.GetNodeAt(skipTarget);

        ListNode nextNodeSource = sourceListNode.Next;

        targetListNode.Next = nextNodeSource;

        return targetHeadNode;
    }
}