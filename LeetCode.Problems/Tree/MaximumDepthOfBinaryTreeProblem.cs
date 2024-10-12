using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

public class MaximumDepthOfBinaryTreeProblem
{
    public int MaxDepth(TreeNode root)
    {
        return MaxDepthStack(root);
        return MaxDepthRecursion(root);
    }

    private static int MaxDepthStack(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        Stack<(TreeNode, int)> treeStack = new Stack<(TreeNode, int)>();

        treeStack.Push((root, 1));

        int depth = 0;

        while (treeStack.Count != 0)
        {
            var current = treeStack.Pop();

            depth = Math.Max(depth, current.Item2);

            if (current.Item1.Left != null)
            {
                treeStack.Push((current.Item1.Left, current.Item2 + 1));
            }

            if (current.Item1.Right != null)
            {
                treeStack.Push((current.Item1.Right, current.Item2 + 1));
            }
        }

        return depth;
    }

    private static int MaxDepthRecursion(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            int leftHeight = MaxDepthRecursion(root.Left);
            int rightHeight = MaxDepthRecursion(root.Right);

            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }
}