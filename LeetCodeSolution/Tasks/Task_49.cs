using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_49 : ITask<String[], IList<IList<string>>>
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
