using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

/// <summary>
/// https://leetcode.com/problems/count-good-nodes-in-binary-tree
/// </summary>
public class CountGoodNodesInBinaryTreeProblem
{
    public int GoodNodes(TreeNode rootNode)
    {
        int goodNodeCount = 1;

        int leftNodesCount = CountGoodNodes(rootNode.Left, rootNode.Value);
        int rightNodesCount = CountGoodNodes(rootNode.Right, rootNode.Value);

        return goodNodeCount + leftNodesCount + rightNodesCount;
    }

    private static int CountGoodNodes(TreeNode treeNode, int maximumValue)
    {
        int count = 0;

        if (treeNode != null)
        {
            int currentValue = treeNode.Value;

            if (currentValue >= maximumValue)
            {
                count++;
                maximumValue = currentValue;
            }

            count += CountGoodNodes(treeNode.Left, maximumValue);
            count += CountGoodNodes(treeNode.Right, maximumValue);
        }

        return count;
    }
}