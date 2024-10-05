using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

public class BinaryTreeRightSideViewProblem
{
    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> rightSideView = new List<int>();

        if (root != null)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();

            nodeQueue.Enqueue(root);

            while (nodeQueue.Count > 0)
            {
                int size = nodeQueue.Count;

                for (int i = 0; i < size; i++)
                {
                    var currentNode = nodeQueue.Dequeue();

                    if (i == size - 1)
                    {
                        rightSideView.Add(currentNode.Value);
                    }

                    if (currentNode.Left != null)
                    {
                        nodeQueue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        nodeQueue.Enqueue(currentNode.Right);
                    }
                }
            }
        }

        return rightSideView;
    }
}