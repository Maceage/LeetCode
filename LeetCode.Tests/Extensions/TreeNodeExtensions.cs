using System.Text;
using LeetCode.Problems.Data;

namespace LeetCode.Tests.Extensions;

public static class TreeNodeExtensions
{
    public static TreeNode CreateTree(this int?[] nodeValues)
    {
        TreeNode rootNode = new TreeNode();

        if (nodeValues.Length > 0)
        {
            rootNode.Value = nodeValues[0]!.Value;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(rootNode);

            int i = 1;

            while (i < nodeValues.Length)
            {
                TreeNode currentNode = queue.Dequeue();

                if (i < nodeValues.Length)
                {
                    int? leftValue = nodeValues[i++];

                    currentNode.Left = new TreeNode();

                    queue.Enqueue(currentNode.Left);

                    if (leftValue.HasValue)
                    {
                        currentNode.Left.Value = leftValue.Value;
                    }

                    int? rightValue = nodeValues[i++];

                    currentNode.Right = new TreeNode();

                    queue.Enqueue(currentNode.Right);

                    if (rightValue.HasValue)
                    {
                        currentNode.Right.Value = rightValue.Value;
                    }
                }
            }
        }

        return rootNode;
    }
}