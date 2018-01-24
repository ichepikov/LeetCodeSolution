using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Solutions
{
    public class TaskSolution342 : ITaskSolution<int, bool>
    {
        public bool Run(int input)
        {
            return IsPowerOfFour(input);
        }

        public bool IsPowerOfFour(int num)
        {
            if (num <= 0)
                return false;

            while ((num & 3) == 0)
                num = num >> 2;

            return num == 1;
        }
    }
}
