namespace LeetCode.Problems.Heap;

public class KthLargestElementInAnArrayProblem
{
    public int FindKthLargest(int[] nums, int k)
    {
        return FindKthLargestPriorityQueue(nums, k);
        return FindKthLargestQuickSelect(nums, k);
    }

    private static int FindKthLargestPriorityQueue(int[] nums, int k)
    {
        PriorityQueue<int, int> priorityQueue = new();

        foreach (int num in nums)
        {
            priorityQueue.Enqueue(num, num);

            if (priorityQueue.Count > k)
            {
                priorityQueue.Dequeue();
            }
        }

        return priorityQueue.Peek();
    }

    private static int FindKthLargestQuickSelect(int[] nums, int k)
    {
        List<int> list = nums.ToList();

        return QuickSelect(list, k);
    }

    private static int QuickSelect(List<int> nums, int k)
    {
        int pivotIndex = new Random().Next(nums.Count);
        int pivot = nums[pivotIndex];

        List<int> left = new List<int>();
        List<int> mid = new List<int>();
        List<int> right = new List<int>();

        foreach (int num in nums)
        {
            if (num > pivot)
            {
                left.Add(num);
            }
            else if (num < pivot)
            {
                right.Add(num);
            }
            else
            {
                mid.Add(num);
            }
        }

        if (k <= left.Count)
        {
            return QuickSelect(left, k);
        }

        if (left.Count + mid.Count < k)
        {
            return QuickSelect(right, k - left.Count - mid.Count);
        }

        return pivot;
    }
}