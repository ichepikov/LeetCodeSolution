using System.Collections.Generic;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_78 : ITask<int[], IList<IList<int>>>
    {
        public IList<IList<int>> Run(int[] input)
        {
            return Subsets(input);
        }

        public IList<IList<int>> Subsets(int[] nums)
        {
            var responceCount = 1 << nums.Length;

            var result = new List<IList<int>>(responceCount);

            for (int i = 0; i < responceCount; i++)
            {
                var itemIndex = i;
                var set = new List<int>();
                int j = 0;
                while (itemIndex > 0)
                {
                    if ((itemIndex & 1) == 1)
                        set.Add(nums[j]);

                    itemIndex = itemIndex >> 1;
                    j++;
                }

                result.Add(set);
            }

            return result;
        }
    }
}
