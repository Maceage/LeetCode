namespace LeetCode.Problems.Graph;

/// <summary>
/// https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero
/// </summary>
public class ReorderRoutesToMakeAllPathsLeadToTheCityZeroProblem
{
    private int _count;

    public int MinReorder(int n, int[][] connections)
    {
        Dictionary<int, List<List<int>>> adj = new Dictionary<int, List<List<int>>>();

        foreach (int[] connection in connections)
        {
            int parent = connection[0];
            int child = connection[1];

            if (!adj.ContainsKey(parent))
            {
                List<List<int>> list = [[child, 1]];

                adj.Add(parent, list);
            }
            else
            {
                adj[parent].Add([child, 1]);
            }

            if (!adj.ContainsKey(child))
            {
                List<List<int>> list = [[parent, 0]];

                adj.Add(child, list);
            }
            else
            {
                adj[child].Add([parent, 0]);
            }
        }

        ////DepthFirstSearch(0, -1, adj);
        BreadthFirstSearch(0, n, adj);

        return _count;
    }

    private void DepthFirstSearch(int node, int parent, Dictionary<int, List<List<int>>> adj)
    {
        if (adj.TryGetValue(node, out var value))
        {
            foreach (List<int> edges in value)
            {
                int neighbour = edges[0];
                int sign = edges[1];

                if (neighbour != parent)
                {
                    _count += sign;

                    DepthFirstSearch(neighbour, node, adj);
                }
            }
        }
    }

    private void BreadthFirstSearch(int node, int n, Dictionary<int, List<List<int>>> adj)
    {
        Queue<int> intQueue = new Queue<int>();

        bool[] visit = new bool[n];

        intQueue.Enqueue(node);

        visit[node] = true;

        while (intQueue.Count > 0)
        {
            node = intQueue.Dequeue();

            if (adj.TryGetValue(node, out var value))
            {
                foreach (List<int> edges in value)
                {
                    int neighbour = edges[0];
                    int sign = edges[1];

                    if (!visit[neighbour])
                    {
                        _count += sign;

                        visit[neighbour] = true;

                        intQueue.Enqueue(neighbour);
                    }
                }
            }
        }
    }
}