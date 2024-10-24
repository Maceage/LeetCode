using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

/// <summary>
/// https://leetcode.com/problems/search-in-a-binary-search-tree
/// </summary>
public class SearchInABinarySearchTreeProblem
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        TreeNode resultNode = null;

        Stack<TreeNode> nodeStack = new Stack<TreeNode>();

        nodeStack.Push(root);

        while (nodeStack.Count > 0)
        {
            var currentNode = nodeStack.Pop();

            if (currentNode.Value == val)
            {
                resultNode = currentNode;
                break;
            }

            if ((currentNode?.Left != null) && (currentNode?.Value > val))
            {
                nodeStack.Push(currentNode.Left);
            }

            if ((currentNode?.Right != null) && (currentNode?.Value < val))
            {
                nodeStack.Push(currentNode.Right);
            }
        }

        return resultNode;
    }
}