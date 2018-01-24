using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Solutions
{
    public class TaskSolution49 : ITaskSolution<String[], IList<IList<string>>>
    {
        public IList<IList<string>> Run(string[] input)
        {
            return GroupAnagrams(input);
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            return strs.Select(e => new {Key = new string(e.OrderBy(c => c).ToArray()), value = e})
                .GroupBy(e => e.Key, e => e.value).Select(e => (IList<string>) e.ToList()).ToList();
        }
    }
}
