using System;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    class Task_327 : ITask<Tuple<int[], int, int>, int>
    {
        public int Run(Tuple<int[], int, int> input)
        {
            return CountRangeSum(input.Item1, input.Item2, input.Item3);
        }

        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            int i = 0, j = 0;


            var result = 0;
            while (i < nums.Length && j < nums.Length)
            {
                
            }

            return result;
        }
    }
}
