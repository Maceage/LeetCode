namespace LeetCode.Problems.Heap;

/// <summary>
/// https://leetcode.com/problems/total-cost-to-hire-k-workers
/// </summary>
public class TotalCostToHireKWorkersProblem
{
    public long TotalCost(int[] costs, int k, int candidates)
    {
        long totalCost = 0;

        PriorityQueue<int, int> leftHeap = new PriorityQueue<int, int>(candidates);

        for (int i = 0; i < candidates; i++)
        {
            int cost = costs[i];

            leftHeap.Enqueue(cost, cost);
        }

        PriorityQueue<int, int> rightHeap = new PriorityQueue<int, int>(candidates);

        for (int i = Math.Max(candidates, costs.Length - candidates); i < costs.Length; i++)
        {
            int cost = costs[i];

            rightHeap.Enqueue(cost, cost);
        }

        int leftNextIndex = candidates;
        int rightNextIndex = costs.Length - candidates - 1;

        for (int i = 0; i < k; i++)
        {
            if ((rightHeap.Count <= 0) || (leftHeap.Count > 0) && (leftHeap.Peek() <= rightHeap.Peek()))
            {
                totalCost += leftHeap.Dequeue();

                if (leftNextIndex <= rightNextIndex)
                {
                    int cost = costs[leftNextIndex];

                    leftHeap.Enqueue(cost, cost);

                    leftNextIndex++;
                }
            }
            else
            {
                totalCost += rightHeap.Dequeue();

                if (leftNextIndex <= rightNextIndex)
                {
                    int cost = costs[rightNextIndex];

                    rightHeap.Enqueue(cost, cost);

                    rightNextIndex--;
                }
            }
        }

        return totalCost;
    }
}