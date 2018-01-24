using System;
using System.Linq;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Solutions
{
    public class TaskSolution151 : ITaskSolution<string, string>
    {
        public string Run(string input)
        {
            return ReverseWords(input);
        }

        public string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Reverse());
        }
    }
}
