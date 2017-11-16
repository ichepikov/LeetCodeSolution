﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                if (dif < 0)
                {
                    if (interval <= 0)
                    {
                        interval += dif;
                    }
                    else
                    {
                        intervals.Add(interval);
                        interval = dif;
                    }
                }
                else if (dif > 0)
                {
                    if (interval >= 0)
                    {
                        interval += dif;
                    }
                    else
                    {
                        intervals.Add(interval);
                        interval = dif;
                    }
                }
            }

            if (interval == 0)
                return 0;

            intervals.Add(interval);

            if (intervals[0] < 0)
                intervals.RemoveAt(0);

            if (intervals.Count > 0 && intervals[intervals.Count - 1] < 0)
                intervals.RemoveAt(intervals.Count - 1);

            var sum = 0;

            for (int i = 0; i < intervals.Count; i = i + 2)
                sum += intervals[i];

            var intervalsToRemove = (intervals.Count / 2 - k) + 1;



            for (int i = 0; i < intervalsToRemove; i++)
            {
                var minInterval = intervals.Select(Math.Abs).Min();
                var index = intervals.IndexOf(minInterval);
                if (index < 0)
                    index = intervals.IndexOf(-minInterval);

                if (index == 0)
                {
                    intervals.RemoveAt(1);
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
                    intervals.RemoveAt(index - 1);
                    intervals.Insert(index - 1, newItem);
                }

                sum -= minInterval;
            }

            return sum;
        }
    }
}
