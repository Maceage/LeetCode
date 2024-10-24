namespace LeetCode.Problems.Graph;

/// <summary>
/// https://leetcode.com/problems/number-of-provinces
/// </summary>
public class NumberOfProvincesProblem
{
    public int FindCircleNum(int[][] isConnected)
    {
        int n = isConnected.Length;
        int numberOfComponents = 0;

        bool[] visit = new bool[n];

        for (int i = 0; i < n; i++)
        {
            if (!visit[i])
            {
                numberOfComponents++;

                //DepthFirstSearch(i, isConnected, visit);
                BreadthFirstSearch(i, isConnected, visit);
            }
        }

        return numberOfComponents;
    }

    private static void DepthFirstSearch(int node, int[][] isConnected, bool[] visit)
    {
        visit[node] = true;

        for (int i = 0; i < isConnected.Length; i++)
        {
            if (isConnected[node][i] == 1 && !visit[i])
            {
                DepthFirstSearch(i, isConnected, visit);
            }
        }
    }

    private static void BreadthFirstSearch(int node, int[][] isConnected, bool[] visit)
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(node);

        visit[node] = true;

        while (queue.Count > 0)
        {
            node = queue.Dequeue();

            for (int i = 0; i < isConnected.Length; i++)
            {
                if (isConnected[node][i] == 1 && !visit[i])
                {
                    queue.Enqueue(i);
                    visit[i] = true;
                }
            }
        }
    }
}