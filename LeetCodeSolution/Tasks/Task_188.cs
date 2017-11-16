using System;
using System.Collections.Generic;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_188 : ITask<Tuple<int, int[]>, int>
    {
        public int Run(Tuple<int, int[]> input)
        {
            return MaxProfit(input.Item1, input.Item2);
        }

        public int MaxProfit(int k, int[] prices)
        {
            if (k == 0)
                return 0;

            var intervals = new List<int>();

            var interval = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                var dif = prices[i] - prices[i - 1];

                if ((dif <= 0 && interval <= 0) || (dif >= 0 && interval >= 0))
                {
                    if (interval != 0 || dif > 0)
                        interval += dif;
                }
                else
                {
                    intervals.Add(interval);
                    interval = dif;
                }
            }

            if (interval == 0)
                return 0;

            if (interval > 0)
                intervals.Add(interval);


            var sum = 0;
            for (int i = 0; i < intervals.Count; i = i + 2)
                sum += intervals[i];


            var intervalsToRemove = (intervals.Count / 2) - k + 1;

            for (int i = 0; i < intervalsToRemove; i++)
            {
                var index = 0;
                var minInterval = intervals[0];
                for (int j = 1; j < intervals.Count; j++)
                {
                    var current = Math.Abs(intervals[j]);
                    if (minInterval > current)
                    {
                        minInterval = current;
                        index = j;
                    }
                }

                if (index == 0)
                {
                    intervals.RemoveAt(0);
                    intervals.RemoveAt(0);
                }
                else if (index == intervals.Count - 1)
                {
                    intervals.RemoveAt(intervals.Count - 1);
                    intervals.RemoveAt(intervals.Count - 1);
                }
                else
                {
                    var newItem = intervals[index - 1] + intervals[index] + intervals[index + 1];
                    intervals.RemoveAt(index - 1);
                    intervals.RemoveAt(index - 1);
                    intervals[index - 1] = newItem;
                }

                sum -= minInterval;
            }

            return sum;
        }
    }
}
