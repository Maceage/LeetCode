namespace LeetCode.Problems.Data;

public class TrieNode
{
    private readonly TrieNode[] _childNodes;

    private bool _end;

    public TrieNode()
    {
        _childNodes = new TrieNode[26];
    }

    public bool ContainsKey(char currentChar)
    {
        return _childNodes[currentChar - 'a'] != null;
    }

    public TrieNode Get(char currentChar)
    {
        return _childNodes[currentChar - 'a'];
    }

    public void Put(char currentChar, TrieNode trieNode)
    {
        _childNodes[currentChar - 'a'] = trieNode;
    }
    
    public void SetEnd()
    {
        _end = true;
    }

    public bool IsEnd()
    {
        return _end;
    }
}