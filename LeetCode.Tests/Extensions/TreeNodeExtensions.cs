﻿using LeetCode.Problems.Data;

namespace LeetCode.Tests.Extensions;

public static class TreeNodeExtensions
{
    public static TreeNode CreateTree(this int?[] nodeValues)
    {
        TreeNode rootNode = null;

        if (nodeValues.Length > 0)
        {
            rootNode = new TreeNode();

            rootNode.Value = nodeValues[0]!.Value;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(rootNode);

            int i = 1;

            while (i < nodeValues.Length)
            {
                TreeNode currentNode = queue.Dequeue();

                if (i < nodeValues.Length)
                {
                    int? leftValue = nodeValues.ElementAtOrDefault(i++);

                    if (leftValue.HasValue)
                    {
                        currentNode.Left = new TreeNode();

                        queue.Enqueue(currentNode.Left);

                        currentNode.Left.Value = leftValue.Value;
                    }

                    int? rightValue = nodeValues.ElementAtOrDefault(i++);

                    if (rightValue.HasValue)
                    {
                        currentNode.Right = new TreeNode();

                        queue.Enqueue(currentNode.Right);

                        currentNode.Right.Value = rightValue.Value;
                    }
                }
            }
        }

        return rootNode;
    }

    public static TreeNode FindNodeWithValue(this TreeNode treeNode, int nodeValue)
    {
        TreeNode nodeWithValue = null;

        if (treeNode != null)
        {
            if (treeNode.Value == nodeValue)
            {
                nodeWithValue = treeNode;
            }
            else
            {
                if (treeNode.Left != null)
                {
                    nodeWithValue = FindNodeWithValue(treeNode.Left, nodeValue);
                }

                if (nodeWithValue == null && treeNode.Right != null)
                {
                    nodeWithValue = FindNodeWithValue(treeNode.Right, nodeValue);
                }
            }
        }

        return nodeWithValue;
    }

    public static int?[] GetNodeValues(this TreeNode treeNode)
    {
        List<int?> nodeValues = new List<int?>();

        Queue<TreeNode> nodesQueue = new Queue<TreeNode>();

        nodesQueue.Enqueue(treeNode);

        while (nodesQueue.Count > 0)
        {
            var currentNode = nodesQueue.Dequeue();

            if (currentNode != null)
            {
                nodeValues.Add(currentNode.Value);
            }
            else
            {
                nodeValues.Add(null);
            }

            if ((currentNode?.Left != null) || (currentNode?.Right != null))
            {
                nodesQueue.Enqueue(currentNode.Left);
                nodesQueue.Enqueue(currentNode.Right);
            }
        }

        while ((nodeValues.Count > 0) && (nodeValues.Last() == null))
        {
            nodeValues.RemoveAt(nodeValues.Count - 1);
        }

        return nodeValues.ToArray();
    }
}