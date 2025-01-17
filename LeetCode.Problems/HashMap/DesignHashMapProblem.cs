namespace LeetCode.Problems.HashMap;

/// <summary>
/// https://leetcode.com/problems/design-hashmap
/// </summary>
public class DesignHashMapProblem
{
    public class MyHashMap
    {
        private readonly int _keySpace;
        private readonly List<Bucket> _hashTable;

        public MyHashMap()
        {
            // Prime number is best
            _keySpace = 2069;
            _hashTable = new List<Bucket>();

            for (int i = 0; i < _keySpace; i++)
            {
                _hashTable.Add(new Bucket());
            }
        }

        public void Put(int key, int value)
        {
            int hashKey = key % _keySpace;

            _hashTable[hashKey].Update(key, value);
        }

        public int Get(int key)
        {
            int hashKey = key % _keySpace;

            return _hashTable[hashKey].Get(key);
        }

        public void Remove(int key)
        {
            int hashKey = key % _keySpace;

            _hashTable[hashKey].Remove(key);
        }

        private class Pair<T, U>(T first, U second)
        {
            public T First { get; set; } = first;
            public U Second { get; set; } = second;
        }

        private class Bucket
        {
            private readonly List<Pair<int, int>> _bucket = [];

            public int Get(int key)
            {
                foreach (var pair in _bucket)
                {
                    if (pair.First.Equals(key))
                    {
                        return pair.Second;
                    }
                }

                return -1;
            }

            public void Update(int key, int value)
            {
                bool found = false;

                foreach (var pair in _bucket)
                {
                    if (pair.First.Equals(key))
                    {
                        pair.Second = value;
                        found = true;
                    }
                }

                if (!found)
                {
                    _bucket.Add(new Pair<int, int>(key, value));
                }
            }

            public void Remove(int key)
            {
                foreach (var pair in _bucket)
                {
                    if (pair.First.Equals(key))
                    {
                        _bucket.Remove(pair);
                        break;
                    }
                }
            }
        }
    }
}