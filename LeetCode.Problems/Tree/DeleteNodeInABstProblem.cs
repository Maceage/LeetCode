using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

public class DeleteNodeInABstProblem
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
        {
            return null;
        }

        if (key > root.Value)
        {
            root.Right = DeleteNode(root, key);
        }
        else if (key < root.Value)
        {
            root.Left = DeleteNode(root.Left, key);
        }
        else
        {
            if ((root.Left == null) && (root.Right == null))
            {
                root = null;
            }
            else if (root.Right != null)
            {
                root.Value = Successor(root);
                root.Right = DeleteNode(root.Right, root.Value);
            }
            else
            {
                root.Value = Predecessor(root);
                root.Left = DeleteNode(root.Left, root.Value);
            }
        }

        return root;
    }

    private static int Successor(TreeNode root)
    {
        root = root.Right;

        while (root.Left != null)
        {
            root = root.Left;
        }

        return root.Value;
    }

    private static int Predecessor(TreeNode root)
    {
        root = root.Left;

        while (root.Right != null)
        {
            root = root.Right;
        }

        return root.Value;
    }
}