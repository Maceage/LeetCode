namespace LeetCode.Problems;

public class NumberOfRecentCallsProblem
{
    public class RecentCounter
    {
        private readonly Queue<int> _counterQueue = new();

        private readonly int recencyLimit = 3000;

        public int Ping(int t)
        {
            _counterQueue.Enqueue(t);

            int recency = t - recencyLimit;
            int current = _counterQueue.Peek();

            while (current < recency)
            {
                _counterQueue.Dequeue();

                current = _counterQueue.Peek();
            }

            return _counterQueue.Count;
        }
    }
}
