using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

/// <summary>
/// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree
/// </summary>
public class LowestCommonAncestorOfBinaryTreeProblem
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode lowestCommonAncestor = null;

        Stack<TreeNode> qStack = new Stack<TreeNode>();
        Stack<TreeNode> pStack = new Stack<TreeNode>();

        qStack.Push(root);
        pStack.Push(root);

        pStack = GetPathToNode(root, p, pStack);
        qStack = GetPathToNode(root, q, qStack);

        // Find common node across both paths
        TreeNode leftNode = null;
        TreeNode rightNode = null;

        while ((pStack.Count >= 0) && (qStack.Count >= 0))
        {
            leftNode ??= pStack.Pop();
            rightNode ??= qStack.Pop();

            if (leftNode == rightNode)
            {
                lowestCommonAncestor = leftNode;
                break;
            }

            if (pStack.Count > qStack.Count)
            {
                leftNode = pStack.Pop();
            }
            else if (qStack.Count > pStack.Count)
            {
                rightNode = qStack.Pop();
            }
            else
            {
                leftNode = pStack.Pop();
            }
        }

        return lowestCommonAncestor;
    }

    private static Stack<TreeNode> GetPathToNode(TreeNode parentNode, TreeNode nodeToFind, Stack<TreeNode> parentTreeNodes)
    {
        if (parentNode == nodeToFind)
        {
            return parentTreeNodes;
        }

        if (parentNode.Left != null)
        {
            parentTreeNodes.Push(parentNode.Left);

            parentTreeNodes = GetPathToNode(parentNode.Left, nodeToFind, parentTreeNodes);

            if ((parentTreeNodes.Count > 0) && (parentTreeNodes.Peek() == nodeToFind))
            {
                return parentTreeNodes;
            }

            parentTreeNodes.Pop();
        }

        if (parentNode.Right != null)
        {
            parentTreeNodes.Push(parentNode.Right);

            parentTreeNodes = GetPathToNode(parentNode.Right, nodeToFind, parentTreeNodes);

            if ((parentTreeNodes.Count > 0) && (parentTreeNodes.Peek() == nodeToFind))
            {
                return parentTreeNodes;
            }

            parentTreeNodes.Pop();
        }

        return parentTreeNodes;
    }
}