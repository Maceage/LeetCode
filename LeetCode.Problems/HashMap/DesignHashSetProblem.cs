using LeetCode.Problems.Data;

namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/design-hashset
/// </summary>
public class DesignHashSetProblem
{
    public class MyHashSetWithBinarySearchTree
    {
        private readonly Bucket[] _bucketArray;
        private readonly int _keyRange;

        public MyHashSetWithBinarySearchTree()
        {
            // Prime number is best
            _keyRange = 769;

            _bucketArray = new Bucket[_keyRange];

            for (int i = 0; i < _keyRange; i++)
            {
                _bucketArray[i] = new Bucket();
            }
        }

        private int Hash(int key)
        {
            return key % _keyRange;
        }

        public void Add(int key)
        {
            int bucketIndex = Hash(key);

            _bucketArray[bucketIndex].Add(key);
        }

        public void Remove(int key)
        {
            int bucketIndex = Hash(key);

            _bucketArray[bucketIndex].Remove(key);
        }

        public bool Contains(int key)
        {
            int bucketIndex = Hash(key);

            return _bucketArray[bucketIndex].Contains(key);
        }

        private class Bucket
        {
            private readonly BSTree _tree = new();

            public void Add(int key)
            {
                _tree.Root = BSTree.InsertIntoBST(_tree.Root, key);
            }

            public void Remove(int key)
            {
                _tree.Root = BSTree.DeleteNode(_tree.Root, key);
            }

            public bool Contains(int key)
            {
                TreeNode treeNode = BSTree.SearchBST(_tree.Root, key);

                return treeNode != null;
            }
        }

        private class BSTree
        {
            public TreeNode Root { get; set; }

            public static TreeNode SearchBST(TreeNode root, int value)
            {
                if (root == null || value == root.Value)
                {
                    return root;
                }

                return value < root.Value ? SearchBST(root.Left, value) : SearchBST(root.Right, value);
            }

            public static TreeNode InsertIntoBST(TreeNode root, int value)
            {
                if (root == null)
                {
                    return new TreeNode(value);
                }

                if (value > root.Value)
                {
                    root.Right = InsertIntoBST(root.Right, value);
                }
                else if (value == root.Value)
                {
                    return root;
                }
                else
                {
                    root.Left = InsertIntoBST(root.Left, value);
                }

                return root;
            }

            public static TreeNode DeleteNode(TreeNode root, int key)
            {
                if (root == null)
                {
                    return null;
                }

                if (key > root.Value)
                {
                    root.Right = DeleteNode(root.Right, key);
                }
                else if (key < root.Value)
                {
                    root.Left = DeleteNode(root.Left, key);
                }
                else
                {
                    if (root.Left == null && root.Right == null)
                    {
                        root = null;
                    }
                    else if (root.Right != null)
                    {
                        root.Value = Successor(root);
                        root.Right = DeleteNode(root.Right, root.Value);
                    }
                    else if (root.Left != null)
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
    }

    public class MyHashSetWithLinkedList
    {
        private readonly Bucket[] _bucketArray;

        private readonly int _keyRange;

        public MyHashSetWithLinkedList()
        {
            // Prime number is best
            _keyRange = 769;

            _bucketArray = new Bucket[_keyRange];

            for (int i = 0; i < _keyRange; i++)
            {
                _bucketArray[i] = new Bucket();
            }
        }

        private int Hash(int key)
        {
            return (key % _keyRange);
        }

        public void Add(int key)
        {
            int bucketIndex = Hash(key);

            _bucketArray[bucketIndex].Insert(key);
        }

        public void Remove(int key)
        {
            int bucketIndex = Hash(key);

            _bucketArray[bucketIndex].Delete(key);
        }

        public bool Contains(int key)
        {
            int bucketIndex = Hash(key);

            return _bucketArray[bucketIndex].Exists(key);
        }

        private class Bucket
        {
            private readonly LinkedList<int> _container = [];

            public void Insert(int key)
            {
                LinkedListNode<int>? node = _container.Find(key);

                if (node == null)
                {
                    _container.AddFirst(key);
                }
            }

            public void Delete(int key)
            {
                _container.Remove(key);
            }

            public bool Exists(int key)
            {
                return _container.Find(key) != null;
            }
        }
    }
}