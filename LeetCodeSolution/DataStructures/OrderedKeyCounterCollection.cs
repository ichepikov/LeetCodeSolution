using System.Collections.Generic;

namespace LeetCodeSolution.DataStructures
{
    public class OrderedKeyCounterCollection<TKey>
    {
        private readonly LinkedList<Element> _orderedList = new LinkedList<Element>();

        private readonly Dictionary<TKey, LinkedListNode<Element>> _dictionary =
            new Dictionary<TKey, LinkedListNode<Element>>();

        /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
        public void Increment(TKey key)
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
        public void Decrement(TKey key)
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
        
        /** Returns keys ordered by its value. */
        public IEnumerable<TKey> GetOrderedKeys()
        {
            var node = _orderedList.First;

            while (node != null)
            {
                yield return node.Value.Key;
                node = node.Next;
            }
        }

        public IEnumerable<TKey> GetOrderedDescendingKeys()
        {
            var node = _orderedList.Last;

            while (node != null)
            {
                yield return node.Value.Key;
                node = node.Previous;
            }
        }

        private class Element
        {
            public Element(TKey key)
            {
                Key = key;
            }

            public TKey Key { get; }
            public int Counter { get; set; }
        }
    }
}
