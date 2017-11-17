using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_347 : ITask<Tuple<int[], int>, IList<int>>
    {
        public IList<int> Run(Tuple<int[], int> input)
        {
            return TopKFrequent(input.Item1, input.Item2);
        }

        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var elements = new ElemetsCounter();

            foreach (var num in nums)
                elements.AddElement(num);

            return elements.GetMostFrequentItems().Take(k).ToArray();
        }

        private class ElemetsCounter
        {
            private class Element
            {
                public Element(int key)
                {
                    Key = key;
                }

                public int Key { get; }
                public int Counter { get; set; }
            }

            private readonly LinkedList<Element> _orderedList = new LinkedList<Element>();

            private readonly Dictionary<int, LinkedListNode<Element>> _dictionary =
                new Dictionary<int, LinkedListNode<Element>>();

            public void AddElement(int i)
            {
                if (_dictionary.ContainsKey(i))
                {
                    var node = _dictionary[i];
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
                    var node = new LinkedListNode<Element>(new Element(i));
                    _orderedList.AddFirst(node);

                    _dictionary[i] = node;
                }
            }

            public IEnumerable<int> GetMostFrequentItems()
            {
                var node = _orderedList.Last;
                while (node != null)
                {
                    yield return node.Value.Key;
                    node = node.Previous;
                }
            }
        }
    }
}
