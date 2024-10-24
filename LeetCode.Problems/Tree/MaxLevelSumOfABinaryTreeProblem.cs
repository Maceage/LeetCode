using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

/// <summary>
/// https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree
/// </summary>
public class MaxLevelSumOfABinaryTreeProblem
{
    public int MaxLevelSum(TreeNode root)
    {
        int maxLevel = 0;

        if (root != null)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();

            nodeQueue.Enqueue(root);

            int maxSum = int.MinValue;
            int currentLevel = 1;

            while (nodeQueue.Count> 0)
            {
                int size = nodeQueue.Count;

                int sum = 0;

                for (int i = 0; i < size; i++)
                {
                    var currentNode = nodeQueue.Dequeue();

                    sum += currentNode.Value;

                    if (currentNode.Left != null)
                    {
                        nodeQueue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        nodeQueue.Enqueue(currentNode.Right);
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxLevel = currentLevel;
                }

                currentLevel++;
            }
        }

        return maxLevel;
    }
}