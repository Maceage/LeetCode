namespace LeetCode.Problems.LinkedList;

/// <summary>
/// https://leetcode.com/problems/all-oone-data-structure
/// </summary>
public class AllOneProblem
{
    public class Node
    {
        public int Frequency { get; }
        public Node Previous { get; set; }
        public Node Next { get; set; }
        public HashSet<string> Keys { get; }

        public Node(int frequency)
        {
            Frequency = frequency;
            Keys = [];
        }
    }

    public class AllOne
    {
        private readonly Node _head;
        private readonly Node _tail;

        private readonly Dictionary<string, Node> _map = new();

        public AllOne()
        {
            _head = new Node(0);
            _tail = new Node(0);

            _head.Next = _tail;
            _tail.Previous = _head;
        }

        public void Inc(string key)
        {
            if (_map.ContainsKey(key))
            {
                Node node = _map[key];

                int frequency = node.Frequency;

                node.Keys.Remove(key);

                Node nextNode = node.Next;

                if (nextNode == _tail || nextNode.Frequency != frequency + 1)
                {
                    Node newNode = new Node(frequency + 1);

                    newNode.Keys.Add(key);
                    newNode.Previous = node;
                    newNode.Next = nextNode;

                    node.Next = newNode;
                    nextNode.Previous = newNode;

                    _map[key] = newNode;
                }
                else
                {
                    nextNode.Keys.Add(key);

                    _map[key] = nextNode;
                }

                if (node.Keys.Count <= 0)
                {
                    RemoveNode(node);
                }
            }
            else
            {
                Node firstNode = _head.Next;

                if (firstNode == _tail || firstNode.Frequency > 1)
                {
                    Node newNode = new Node(1);

                    newNode.Keys.Add(key);
                    newNode.Previous = _head;
                    newNode.Next = firstNode;

                    _head.Next = newNode;
                    firstNode.Previous = newNode;

                    _map.Add(key, newNode);
                }
                else
                {
                    firstNode.Keys.Add(key);

                    _map.Add(key, firstNode);
                }
            }
        }

        public void Dec(string key)
        {
            if (_map.ContainsKey(key))
            {
                Node node = _map[key];

                node.Keys.Remove(key);

                int frequency = node.Frequency;

                if (frequency == 1)
                {
                    _map.Remove(key);
                }
                else
                {
                    Node previousNode = node.Previous;

                    if (previousNode == _head || previousNode.Frequency != frequency - 1)
                    {
                        Node newNode = new Node(frequency - 1);

                        newNode.Keys.Add(key);
                        newNode.Previous = previousNode;
                        newNode.Next = node;

                        previousNode.Next = newNode;
                        node.Previous = newNode;

                        _map[key] = newNode;
                    }
                    else
                    {
                        previousNode.Keys.Add(key);

                        _map[key] = previousNode;
                    }
                }

                if (node.Keys.Count <= 0)
                {
                    RemoveNode(node);
                }
            }
        }

        public string GetMaxKey()
        {
            if (_tail.Previous == _head)
            {
                return string.Empty;
            }

            return _tail.Previous.Keys.FirstOrDefault();
        }

        public string GetMinKey()
        {
            if (_head.Next == _tail)
            {
                return string.Empty;
            }

            return _head.Next.Keys.FirstOrDefault();
        }

        private static void RemoveNode(Node node)
        {
            Node previousNode = node.Previous;
            Node nextNode = node.Next;

            previousNode.Next = nextNode;
            nextNode.Previous = previousNode;
        }
    }
}