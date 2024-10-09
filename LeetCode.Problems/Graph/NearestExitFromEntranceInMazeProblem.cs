namespace LeetCode.Problems.Graph;

public class NearestExitFromEntranceInMazeProblem
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        int rows = maze.Length;
        int cols = maze[0].Length;

        int[][] dirs = [[1, 0], [-1, 0], [0, 1], [0, -1]];

        // Mark entrance as visited since it's not an exit
        int startRow = entrance[0];
        int startCol = entrance[1];

        maze[startRow][startCol] = '+';

        // Start BFS from entrance and use queue to store all cells to be visited
        Queue<int[]> queue = new Queue<int[]>();

        queue.Enqueue([startRow, startCol, 0]);

        while (queue.Count > 0)
        {
            int[] currState = queue.Dequeue();

            int currRow = currState[0];
            int currCol = currState[1];
            int currDistance = currState[2];

            // Check four neighbour cells from current cell
            foreach (int[] dir in dirs)
            {
                int nextRow = currRow + dir[0];
                int nextCol = currCol + dir[1];

                // If there's an unvisited empty neighbour...
                if (0 <= nextRow && nextRow < rows && 0 <= nextCol && nextCol < cols && maze[nextRow][nextCol] == '.')
                {
                    // If this empty cell is an exit then return distance + 1
                    if (nextRow == 0 || nextRow == rows - 1 || nextCol == 0 || nextCol == cols - 1)
                    {
                        return currDistance + 1;
                    }

                    // Otherwise, add cell to queue and mark as visited
                    maze[nextRow][nextCol] = '+';

                    queue.Enqueue([nextRow, nextCol, currDistance + 1]);
                }
            }
        }

        // Finished iterating without finding an exit
        return -1;
    }
}