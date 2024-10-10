namespace LeetCode.Problems.Heap;

public class KthLargestElementInAnArrayProblem
{
    public int FindKthLargest(int[] nums, int k)
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

    //public int FindKthLargest(int[] nums, int k)
    //{
    //    List<int> list = nums.ToList();

    //    return QuickSelect(list, k);
    //}

    //private static int QuickSelect(List<int> nums, int k)
    //{
    //    int pivotIndex = new Random().Next(nums.Count);
    //    int pivot = nums[pivotIndex];

    //    List<int> left = new List<int>();
    //    List<int> mid = new List<int>();
    //    List<int> right = new List<int>();

    //    foreach (int num in nums)
    //    {
    //        if (num > pivot)
    //        {
    //            left.Add(num);
    //        }
    //        else if (num < pivot)
    //        {
    //            right.Add(num);
    //        }
    //        else
    //        {
    //            mid.Add(num);
    //        }
    //    }

    //    if (k <= left.Count)
    //    {
    //        return QuickSelect(left, k);
    //    }

    //    if (left.Count + mid.Count < k)
    //    {
    //        return QuickSelect(right, k - left.Count - mid.Count);
    //    }

    //    return pivot;
    //}

    //public int FindKthLargest(int[] nums, int k)
    //{
    //    int?[] largestInts = new int?[k];

    //    foreach (int num in nums)
    //    {
    //        for (int i = 0; i < largestInts.Length; i++)
    //        {
    //            int? currentInt = largestInts[i];

    //            if (currentInt.HasValue)
    //            {
    //                if (currentInt < num)
    //                {
    //                    int nextIndex = i + 1;

    //                    if (nextIndex < k)
    //                    {
    //                        largestInts[nextIndex] = currentInt;
    //                    }

    //                    largestInts[i] = num;
    //                }
    //            }
    //            else
    //            {
    //                largestInts[i] = num;
    //                break;
    //            }
    //        }
    //    }

    //    return largestInts[k - 1].Value;
    //}
}