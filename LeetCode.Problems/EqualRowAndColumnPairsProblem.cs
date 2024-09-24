using System.Text;

namespace LeetCode.Problems;

public class EqualRowAndColumnPairsProblem
{
    public int EqualPairs(int[][] grid)
    {
        int pairCount = 0;

        Dictionary<string, int> gridRowCounts = new Dictionary<string, int>();

        foreach (var pair in grid)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var i in pair)
            {
                stringBuilder.Append(i);
                stringBuilder.Append(",");
            }

            string gridKey = stringBuilder.ToString();

            if (!gridRowCounts.TryAdd(gridKey, 1))
            {
                gridRowCounts[gridKey]++;
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var pair in grid)
            {
                int key = pair[i];

                stringBuilder.Append(key);
                stringBuilder.Append(",");
            }

            string gridKey = stringBuilder.ToString();

            if (gridRowCounts.TryGetValue(gridKey, out var count))
            {
                pairCount += count;
            }
        }

        return pairCount;
    }
}