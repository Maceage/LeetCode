using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

/// <summary>
/// https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree
/// </summary>
public class LongestZigZagPathInABinaryTreeProblem
{
    private int _pathLength;

    public int LongestZigZag(TreeNode rootNode)
    {
        LongestZigZagInternal(rootNode, 0, 0);

        return _pathLength;
    }

    private void LongestZigZagInternal(TreeNode treeNode, int leftDepth, int rightDepth)
    {
        if (treeNode != null)
        {
            _pathLength = Math.Max(_pathLength, Math.Max(leftDepth, rightDepth));

            if (treeNode.Left != null)
            {
                LongestZigZagInternal(treeNode.Left, rightDepth + 1, 0);
            }

            if (treeNode.Right != null)
            {
                LongestZigZagInternal(treeNode.Right, 0, leftDepth + 1);
            }
        }
    }
}