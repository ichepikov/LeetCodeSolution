using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_32 : ITask<string, int>
    {
        public int Run(string input)
        {
            return LongestValidParentheses(input);
        }
        
        public int LongestValidParentheses(string s)
        {
            var result = 0;
            var intermediateResult = 0;
            var counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    counter++;
                }
                else
                {
                    if (counter > 0)
                    {
                        counter--;
                        intermediateResult += 2;
                    }
                    else
                    {
                        if (intermediateResult > result)
                            result = intermediateResult;
                        intermediateResult = 0;
                    }
                }
            }

            if (intermediateResult > result)
            {
                if (counter == 0)
                    return intermediateResult;

                var iterationsNumber = intermediateResult + counter;

                counter = 0;
                intermediateResult = 0;

                for (int i = s.Length - 1; i >= s.Length - iterationsNumber; i--)
                {
                    if (s[i] == ')')
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter > 0)
                        {
                            counter--;
                            intermediateResult += 2;
                        }
                        else
                        {
                            if (intermediateResult > result)
                                result = intermediateResult;
                            intermediateResult = 0;
                        }
                    }
                }

                if (intermediateResult > result)
                    result = intermediateResult;
            }

            return result;
        }
    }
}
