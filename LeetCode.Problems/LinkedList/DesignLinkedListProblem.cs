using LeetCode.Problems.Data;

namespace LeetCode.Problems.LinkedList;

public class DesignLinkedListProblem
{
    public class MyLinkedList
    {
        private readonly ListNode _headNode = new();

        private int _size = 0;

        /// <summary>
        /// Get the value of the indexth node in the linked list. If the index is invalid, return -1.
        /// </summary>
        public int Get(int index)
        {
            if ((index < 0) || (index >= _size))
            {
                return -1;
            }

            ListNode currentNode = _headNode;

            for (int i = 0; i < index + 1; ++i)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Value;
        }

        /// <summary>
        /// Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
        /// </summary>
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        /// <summary>
        /// Append a node of value val as the last element of the linked list.
        /// </summary>
        public void AddAtTail(int val)
        {
            AddAtIndex(_size, val);
        }

        /// <summary>
        /// Add a node of value val before the indexth node in the linked list.
        /// If index equals the length of the linked list, the node will be appended to the end of the linked list.
        /// If index is greater than the length, the node will not be inserted.
        /// </summary>
        public void AddAtIndex(int index, int val)
        {
            if (index > _size)
            {
                return;
            }

            if (index < 0)
            {
                index = 0;
            }

            ++_size;

            ListNode previousNode = _headNode;

            for (int i = 0; i < index; ++i)
            {
                previousNode = previousNode.Next;
            }

            ListNode listNode = new ListNode(val);

            listNode.Next = previousNode.Next;
            previousNode.Next = listNode;
        }

        /// <summary>
        /// Delete the indexth node in the linked list, if the index is valid.
        /// </summary>
        public void DeleteAtIndex(int index)
        {
            if ((index < 0) || (index >= _size))
            {
                return;
            }

            _size--;

            ListNode previousNode = _headNode;

            for (int i = 0; i < index; ++i)
            {
                previousNode = previousNode.Next;
            }

            previousNode.Next = previousNode.Next.Next;
        }
    }
}