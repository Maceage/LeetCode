using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

public class LeafSimilarTreesProblem
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        int[] leafSequence1 = GetLeafSequence(root1);
        int[] leafSequence2 = GetLeafSequence(root2);

        return leafSequence1.SequenceEqual(leafSequence2);
    }

    private static int[] GetLeafSequence(TreeNode rootNode)
    {
        List<int> leafSequence = new List<int>();

        if (rootNode != null)
        {
            Stack<TreeNode> treeStack = new Stack<TreeNode>();

            treeStack.Push(rootNode);

            while (treeStack.Count != 0)
            {
                var current = treeStack.Pop();

                var leftNode = current.Left;
                var rightNode = current.Right;

                if ((leftNode == null) && (rightNode == null))
                {
                    leafSequence.Add(current.Value);
                }

                if (rightNode != null)
                {
                    treeStack.Push(current.Right);
                }

                if (leftNode != null)
                {
                    treeStack.Push(current.Left);
                }
            }
        }

        return leafSequence.ToArray();
    }
}