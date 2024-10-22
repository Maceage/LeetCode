namespace LeetCode.Problems.Trie;

public class SearchSuggestionsSystemProblem
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        return SuggestedProductsTrieAndDfs(products, searchWord);
        return SuggestedProductsBinarySearch(products, searchWord);
    }

    private static IList<IList<string>> SuggestedProductsTrieAndDfs(string[] products, string searchWord)
    {
        Trie trie = new Trie();

        IList<IList<string>> result = new List<IList<string>>();

        foreach (string product in products)
        {
            trie.Insert(product);
        }

        string prefix = string.Empty;

        foreach (char c in searchWord)
        {
            prefix += c;
            result.Add(trie.GetWordsStartingWith(prefix));
        }

        return result;
    }

    private class Trie
    {
        internal class Node
        {
            internal Node()
            {
                Children = new Node[26];
            }

            public bool IsWord { get; set; }

            public Node[] Children { get; set; }
        }

        private Node _root;
        private Node _currentNode;
        private List<string> _resultBuffer;

        public Trie()
        {
            _root = new Node();
        }

        public void Insert(string s)
        {
            _currentNode = _root;

            foreach (char c in s)
            {
                if (_currentNode.Children[c - 'a'] == null)
                {
                    _currentNode.Children[c - 'a'] = new Node();
                }

                _currentNode = _currentNode.Children[c - 'a'];
            }

            _currentNode.IsWord = true;
        }

        public List<string> GetWordsStartingWith(string prefix)
        {
            _currentNode = _root;

            _resultBuffer = new List<string>();

            foreach (char c in prefix)
            {
                if (_currentNode.Children[c - 'a'] == null)
                {
                    return _resultBuffer;
                }

                _currentNode = _currentNode.Children[c - 'a'];
            }

            DfsWithPrefix(_currentNode, prefix);

            return _resultBuffer;
        }

        private void DfsWithPrefix(Node currentNode, string word)
        {
            if (_resultBuffer.Count == 3)
            {
                return;
            }

            if (currentNode.IsWord)
            {
                _resultBuffer.Add(word);
            }

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (currentNode.Children[c - 'a'] != null)
                {
                    DfsWithPrefix(currentNode.Children[c - 'a'], word + c);
                }
            }
        }
    }

    private static IList<IList<string>> SuggestedProductsBinarySearch(string[] products, string searchWord)
    {
        System.Array.Sort(products);

        IList<IList<string>> result = [];

        int bsStart = 0;
        int n = products.Length;

        string prefix = string.Empty;

        foreach (char c in searchWord)
        {
            prefix += c;

            int start = LowerBound(products, bsStart, prefix);

            result.Add([]);

            for (int i = start; i < Math.Min(start + 3, n); i++)
            {
                if ((products[i].Length < prefix.Length) || !(products[i].Substring(0, prefix.Length)).Equals(prefix))
                {
                    break;
                }

                result[^1].Add(products[i]);
            }

            bsStart = Math.Abs(start);
        }

        return result;
    }

    private static int LowerBound(string[] products, int start, string word)
    {
        int i = start;
        int j = products.Length;
        int mid;

        while (i < j)
        {
            mid = (i + j) / 2;

            if (products[mid].CompareTo(word) >= 0)
            {
                j = mid;
            }
            else
            {
                i = mid + 1;
            }
        }

        return i;
    }
}