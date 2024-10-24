namespace LeetCode.Problems.Graph;

/// <summary>
/// https://leetcode.com/problems/rotting-oranges
/// </summary>
public class RottingOrangesProblem
{
    public int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        int[][] dirs = [[1, 0], [-1, 0], [0, 1], [0, -1]];

        // Find and add co-ordinates of all rotting oranges to queue
        Queue<int[]> queue = new Queue<int[]>();

        int freshOrangeCount = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    freshOrangeCount++;
                }
                else if (grid[i][j] == 2)
                {
                    queue.Enqueue([i, j, 0]);
                }
            }
        }

        int numberOfMinutes = 0;

        // Start BFS from rotting oranges
        while (queue.Count > 0)
        {
            int[] currentOrange = queue.Dequeue();

            int currentRow = currentOrange[0];
            int currentCol = currentOrange[1];
            int currentIteration = currentOrange[2];

            numberOfMinutes = currentIteration;

            // Check each direction for an orange
            foreach (int[] dir in dirs)
            {
                int nextRow = currentRow + dir[0];
                int nextCol = currentCol + dir[1];
                
                // If an orange is found, remove from fresh oranges set and mark it as rotten
                if ((nextRow >= 0) && (nextRow < rows) && (nextCol >= 0) && (nextCol < cols) && (grid[nextRow][nextCol] == 1))
                {
                    grid[nextRow][nextCol] = 2;

                    freshOrangeCount--;

                    queue.Enqueue([nextRow, nextCol, currentIteration + 1]);
                }
            }
        }

        return (freshOrangeCount == 0 ? numberOfMinutes : -1);
    }
}