namespace LeetCode.Problems.Heap;

public class SmallestNumberInInfiniteSetProblem
{
    public class SmallestInfiniteSet
    {
        private int _counter;
        private readonly PriorityQueue<int, int> _priorityQueue;
        private readonly HashSet<int> _numberSet;

        public SmallestInfiniteSet()
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