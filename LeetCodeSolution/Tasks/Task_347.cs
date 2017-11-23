using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeSolution.DataStructures;
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
            var elements = new OrderedKeyCounterCollection<int>();

            foreach (var num in nums)
                elements.Increment(num);

            return elements.GetOrderedDescendingKeys().Take(k).ToArray();
        }
    }
}
