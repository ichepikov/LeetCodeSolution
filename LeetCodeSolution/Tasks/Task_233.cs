using System.Collections.Generic;
using System.Linq;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_233 : ITask<int, int>
    {
        public int Run(int input)
        {
            return CountDigitOne(input);
        }

        public int CountDigitOne(int n)
        {
            var sum = 0;

            var powI = 1;
            var leftNum = n;

            while (n >= powI)
            {
                var currentNumber = leftNum % 10;
                leftNum = leftNum / 10;

                sum += leftNum * powI;

                if (currentNumber > 1)
                    sum += powI;
                else if (currentNumber == 1)
                    sum += n % powI + 1;

                powI *= 10;
            }

            return sum;
        }
    }

    public class Task_233_Answer : ITask<int, int>
    {
        public int Run(int input)
        {
            var sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += GetIntArray(i).Count(e => e == 1);
            }
            return sum;
        }

        private IEnumerable<int> GetIntArray(int num)
        {
            while (num > 0)
            {
                yield return num % 10;
                num = num / 10;
            }
        }
    }
}
