using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeSolution.DataStructures;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_692 : ITask<Tuple<string[], int>, IList<string>>
    {
        public IList<string> Run(Tuple<string[], int> input)
        {
            return TopKFrequent(input.Item1, input.Item2);
        }

        //ToDo: If two words have the same frequency, then the word with the lower alphabetical order comes first.
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var collection = new OrderedKeyCounterCollection<string>();

            foreach (var word in words)
                collection.Increment(word);

            return collection.GetOrderedDescendingKeys().Take(k).ToList();
        }
    }
}
