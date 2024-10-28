namespace LeetCode.Problems.Heap;

/// <summary>
/// https://leetcode.com/problems/smallest-number-in-infinite-set
/// </summary>
public class SmallestNumberInInfiniteSetProblem
{
    public class SmallestInfiniteSetSortedSet
    {
        private readonly SortedSet<int> _addedIntegers = [];
        private int _currentInt = 1;

        public void AddBack(int num)
        {
            if ((_currentInt <= num) || (!_addedIntegers.Add(num)))
            {
                return;
            }
        }

        public int PopSmallest()
        {
            int answer;

            if (_addedIntegers.Count > 0)
            {
                answer = _addedIntegers.First();

                _addedIntegers.Remove(answer);
            }
            else
            {
                answer = _currentInt;

                _currentInt += 1;
            }

            return answer;
        }
    }

    public class SmallestInfiniteSetPriorityQueueHashSet
    {
        private int _counter;
        private readonly PriorityQueue<int, int> _priorityQueue;
        private readonly HashSet<int> _numberSet;

        public SmallestInfiniteSetPriorityQueueHashSet()
        {
            _counter = 0;
            _priorityQueue = new PriorityQueue<int, int>();
            _numberSet = new HashSet<int>();
        }

        public int PopSmallest()
        {
            int smallest;
            int nextNumber = _counter + 1;

            if ((_priorityQueue.Count > 0) && (_priorityQueue.Peek() == nextNumber))
            {
                _priorityQueue.Dequeue();

                smallest = nextNumber;

                _counter = nextNumber;

                _numberSet.Remove(smallest);
            }
            else if ((_priorityQueue.Count > 0) && (_priorityQueue.Peek() < nextNumber))
            {
                smallest = _priorityQueue.Dequeue();

                _numberSet.Remove(smallest);
            }
            else
            {
                smallest = nextNumber;

                _counter = nextNumber;
            }

            return smallest;
        }

        public void AddBack(int num)
        {
            bool hasNumber = _numberSet.Contains(num);

            if (!hasNumber)
            {
                _priorityQueue.Enqueue(num, num);

                _numberSet.Add(num);
            }
        }
    }
}