namespace LeetCode.Problems.Heap;

/// <summary>
/// https://leetcode.com/problems/maximum-subsequence-score
/// </summary>
public class MaximumSubsequenceScoreProblem
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        // Sort pair (nums1[i], nums2[i]) in decreasing order
        int n = nums1.Length;

        int[][] pairs = new int[n][];

        for (int i = 0; i < n; ++i)
        {
            pairs[i] = [nums1[i], nums2[i]];
        }

        System.Array.Sort(pairs, (a, b) => b[1] - a[1]);

        // Use a min-heap to maintain the top k elements
        PriorityQueue<int, int> topKHeap = new PriorityQueue<int, int>(k, Comparer<int>.Create((x, y) => x - y));

        long topKSum = 0;

        for (int i = 0; i < k; ++i)
        {
            int firstPairValue = pairs[i][0];

            topKSum += firstPairValue;

            topKHeap.Enqueue(firstPairValue, firstPairValue);
        }

        // The score of the first k pairs.
        long answer = topKSum * pairs[k - 1][1];

        // Iterate over ever nums2[i] as minimum from nums2
        for (int i = k; i < n; ++i)
        {
            // Remove the smallest integer from the previous top k elements then add nums1[i] to the top k elements.
            int firstPairValue = pairs[i][0];
            int secondPairValue = pairs[i][1];

            topKSum += firstPairValue - topKHeap.Dequeue();

            topKHeap.Enqueue(firstPairValue, firstPairValue);

            // Update answer as maximum score
            answer = Math.Max(answer, topKSum * secondPairValue);
        }

        return answer;
    }
}