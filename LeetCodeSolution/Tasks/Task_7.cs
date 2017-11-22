using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_7 : ITask<int, int>
    {
        public int Run(int input)
        {
            return Reverse(input);
        }

        public int Reverse(int x)
        {
            try
            {
                var output = 0;
                while (x != 0)
                {
                    output = checked(output * 10 + x % 10);
                    x /= 10;
                }
                return output;
            }
            catch
            {
                return 0;
            }
        }
    }
}
