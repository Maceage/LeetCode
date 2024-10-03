using LeetCode.Problems.Data;

namespace LeetCode.Problems.Tree;

public class PathSum3Problem
{
    private int _count;
    private int _k;

    private readonly Dictionary<long, int> _sumCounts = new();

    public int PathSum(TreeNode rootNode, int targetSum)
    {
        _k = targetSum;

        Preorder(rootNode, 0);

        return _count;
    }

    private void Preorder(TreeNode treeNode, long currentSum)
    {
        if (treeNode == null)
        {
            return;
        }

        currentSum += treeNode.Value;

        if (currentSum == _k)
        {
            _count++;
        }

        _count += _sumCounts.GetValueOrDefault(currentSum - _k, 0);

        if (_sumCounts.TryGetValue(currentSum, out var value))
        {
            _sumCounts[currentSum] = value + 1;
        }
        else
        {
            _sumCounts.Add(currentSum, _sumCounts.GetValueOrDefault(currentSum) + 1);
        }

        Preorder(treeNode.Left, currentSum);
        Preorder(treeNode.Right, currentSum);

        if (_sumCounts.TryGetValue(currentSum, out value))
        {
            _sumCounts[currentSum] = value - 1;
        }
        else
        {
            _sumCounts.Add(currentSum, _sumCounts.GetValueOrDefault(currentSum) - 1);
        }
    }
}