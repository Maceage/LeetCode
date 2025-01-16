using LeetCode.Problems.Data;
using LeetCode.Problems.LinkedList;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.LinkedList;

public class AddTwoNumbersProblemTests
{
    [Fact]
    public void AddTwoNumbers_TestCase_1()
    {
        // Arrange
        int[] l1 = [2, 4, 3];
        int[] l2 = [5, 6, 4];

        ListNode head1Node = l1.CreateLinkedList();
        ListNode head2Node = l2.CreateLinkedList();

        AddTwoNumbersProblem addTwoNumbersProblem = new AddTwoNumbersProblem();

        // Act
        ListNode actual = addTwoNumbersProblem.AddTwoNumbers(head1Node, head2Node);

        // Assert
        actual.AssertLinkedList([7, 0, 8]);
    }

    [Fact]
    public void AddTwoNumbers_TestCase_2()
    {
        // Arrange
        int[] l1 = [0];
        int[] l2 = [0];

        ListNode head1Node = l1.CreateLinkedList();
        ListNode head2Node = l2.CreateLinkedList();

        AddTwoNumbersProblem addTwoNumbersProblem = new AddTwoNumbersProblem();

        // Act
        ListNode actual = addTwoNumbersProblem.AddTwoNumbers(head1Node, head2Node);

        // Assert
        actual.AssertLinkedList([0]);
    }

    [Fact]
    public void AddTwoNumbers_TestCase_3()
    {
        // Arrange
        int[] l1 = [9, 9, 9, 9, 9, 9, 9];
        int[] l2 = [9, 9, 9, 9];

        ListNode head1Node = l1.CreateLinkedList();
        ListNode head2Node = l2.CreateLinkedList();

        AddTwoNumbersProblem addTwoNumbersProblem = new AddTwoNumbersProblem();

        // Act
        ListNode actual = addTwoNumbersProblem.AddTwoNumbers(head1Node, head2Node);

        // Assert
        actual.AssertLinkedList([8, 9, 9, 9, 0, 0, 0, 1]);
    }
}