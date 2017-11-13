using System;
using System.Text;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_6 : ITask<Tuple<string, int>, string>
    {
        public string Run(Tuple<string, int> input)
        {
            return Convert(input.Item1, input.Item2);
        }

        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            var mod = 2 * (numRows - 1);

            var stringBuilder = new StringBuilder(s.Length);

            for (int i = 0; i < numRows; i++)
            {
                int step1 = i;
                int step2 = (mod - i) % mod;

                if (step1 != step2)
                    while (true)
                    {
                        if (step1 < s.Length)
                        {
                            stringBuilder.Append(s[step1]);
                            step1 += mod;
                        }
                        else
                            break;
                        if (step2 < s.Length)
                        {
                            stringBuilder.Append(s[step2]);
                            step2 += mod;
                        }
                        else
                            break;
                    }
                else
                {
                    while (true)
                    {
                        if (step1 < s.Length)
                        {
                            stringBuilder.Append(s[step1]);
                            step1 += mod;
                        }
                        else
                            break;
                    }
                }
            }
            return stringBuilder.ToString();
        }
    }
}
