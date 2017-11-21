using System.Collections.Generic;

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
        private readonly LinkedList<Element> _orderedList = new LinkedList<Element>();

        private readonly Dictionary<string, LinkedListNode<Element>> _dictionary =
            new Dictionary<string, LinkedListNode<Element>>();

        /** Initialize your data structure here. */
        public AllOne()
        {

        }

        /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
        public void Inc(string key)
        {
            if (_dictionary.ContainsKey(key))
            {
                var node = _dictionary[key];
                node.Value.Counter++;

                var tempNode = node;

                while (tempNode.Next != null && tempNode.Next.Value.Counter < node.Value.Counter)
                    tempNode = tempNode.Next;

                if (tempNode != node)
                {
                    _orderedList.Remove(node);
                    _orderedList.AddAfter(tempNode, node);
                }
            }
            else
            {
                var node = new LinkedListNode<Element>(new Element(key) {Counter = 1});
                _orderedList.AddFirst(node);
                _dictionary[key] = node;
            }
        }

        /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */
        public void Dec(string key)
        {
            if (_dictionary.ContainsKey(key))
            {
                var node = _dictionary[key];

                if (node.Value.Counter == 1)
                {
                    _dictionary.Remove(key);
                    _orderedList.Remove(node);
                }
                else
                {
                    node.Value.Counter--;

                    var tempNode = node;

                    while (tempNode.Previous != null && tempNode.Previous.Value.Counter > node.Value.Counter)
                        tempNode = tempNode.Previous;

                    if (tempNode != node)
                    {
                        _orderedList.Remove(node);
                        _orderedList.AddBefore(tempNode, node);
                    }
                }
            }
        }

        /** Returns one of the keys with maximal value. */
        public string GetMaxKey()
        {
            if (_orderedList.Last != null)
                return _orderedList.Last.Value.Key;
            return string.Empty;
        }

        /** Returns one of the keys with Minimal value. */
        public string GetMinKey()
        {
            if (_orderedList.First != null)
                return _orderedList.First.Value.Key;
            return string.Empty;
        }

        private class Element
        {
            public Element(string key)
            {
                Key = key;
            }

            public string Key { get; }
            public int Counter { get; set; }
        }
    }
}
