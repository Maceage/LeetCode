using LeetCode.Problems.Data;

namespace LeetCode.Problems.Trie;

public class ImplementTrieProblem
{
    public class Trie
    {
        private readonly TrieNode _root = new();

        public void Insert(string word)
        {
            TrieNode node = _root;

            foreach (var currentChar in word)
            {
                if (!node.ContainsKey(currentChar))
                {
                    node.Put(currentChar, new TrieNode());
                }

                node = node.Get(currentChar);
            }

            node.SetEnd();
        }

        public bool Search(string word)
        {
            TrieNode trieNode = SearchPrefix(word);

            return (trieNode != null) && trieNode.IsEnd();
        }

        public bool StartsWith(string prefix)
        {
            TrieNode trieNode = SearchPrefix(prefix);

            return trieNode != null;
        }

        private TrieNode SearchPrefix(string word)
        {
            TrieNode node = _root;

            foreach (var currentChar in word)
            {
                if (node.ContainsKey(currentChar))
                {
                    node = node.Get(currentChar);
                }
                else
                {
                    return null;
                }
            }

            return node;
        }
    }
}