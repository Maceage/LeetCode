using FluentAssertions;
using LeetCode.Problems.LinkedList;

namespace LeetCode.Tests.LinkedList;

public class DesignLinkedListProblemTests
{
    [Fact]
    public void DesignLinkedList_TestCase_1()
    {
        // Act/Assert
        DesignLinkedListProblem.MyLinkedList myLinkedList = new DesignLinkedListProblem.MyLinkedList();

        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1, 2);
        myLinkedList.Get(1).Should().Be(2);
        myLinkedList.DeleteAtIndex(1);
        myLinkedList.Get(1).Should().Be(3);
    }

    [Fact]
    public void DesignLinkedList_TestCase_2()
    {
        // Act/Assert
        DesignLinkedListProblem.MyLinkedList myLinkedList = new DesignLinkedListProblem.MyLinkedList();

        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1, 2);
        myLinkedList.Get(1).Should().Be(2);
        myLinkedList.DeleteAtIndex(0);
        myLinkedList.Get(0).Should().Be(2);
    }

    [Fact]
    public void DesignLinkedList_TestCase_3()
    {
        // Act/Assert
        DesignLinkedListProblem.MyLinkedList myLinkedList = new DesignLinkedListProblem.MyLinkedList();

        myLinkedList.AddAtHead(2);
        myLinkedList.DeleteAtIndex(1);
        myLinkedList.AddAtHead(2);
        myLinkedList.AddAtHead(7);
        myLinkedList.AddAtHead(3);
        myLinkedList.AddAtHead(2);
        myLinkedList.AddAtHead(5);
        myLinkedList.AddAtTail(5);
        myLinkedList.Get(5).Should().Be(2);
        myLinkedList.DeleteAtIndex(6);
        myLinkedList.DeleteAtIndex(4);
    }

    [Fact]
    public void DesignLinkedList_TestCase_4()
    {
        // Act/Assert
        DesignLinkedListProblem.MyLinkedList myLinkedList = new DesignLinkedListProblem.MyLinkedList();

        myLinkedList.AddAtHead(7);
        myLinkedList.AddAtHead(2);
        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtIndex(3, 0);
        myLinkedList.DeleteAtIndex(2);
        myLinkedList.AddAtHead(6);
        myLinkedList.AddAtTail(4);
        myLinkedList.Get(4).Should().Be(4);
        myLinkedList.AddAtHead(4);
        myLinkedList.AddAtIndex(5, 0);
        myLinkedList.AddAtHead(6);
    }
}