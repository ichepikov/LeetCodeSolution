using System;
using System.Linq;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_151 : ITask<string, string>
    {
        public string Run(string input)
        {
            return ReverseWords(input);
        }

        public string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).Reverse());
        }
    }
}
