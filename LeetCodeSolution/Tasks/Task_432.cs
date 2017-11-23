using System.Linq;
using LeetCodeSolution.DataStructures;

namespace LeetCodeSolution.Tasks
{
    public class Task_432
    {
        public AllOne GetTestClass()
        {
            return new AllOne();
        }
    }

    public class AllOne
    {
        private readonly OrderedKeyCounterCollection<string> _collection;

        /** Initialize your data structure here. */
        public AllOne()
        {
            _collection = new OrderedKeyCounterCollection<string>();
        }

        /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
        public void Inc(string key)
        {
            _collection.Increment(key);
        }

        /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */
        public void Dec(string key)
        {
            _collection.Decrement(key);
        }

        /** Returns one of the keys with maximal value. */
        public string GetMaxKey()
        {
            return _collection.GetOrderedDescendingKeys().FirstOrDefault();
        }

        /** Returns one of the keys with Minimal value. */
        public string GetMinKey()
        {
            return _collection.GetOrderedKeys().FirstOrDefault();
        }
    }
}
