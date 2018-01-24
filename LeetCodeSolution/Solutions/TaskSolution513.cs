using System.Collections.Generic;
using LeetCodeSolution.DataStructures;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Solutions
{
    public class TaskSolution513 : ITaskSolution<TreeNode, int>
    {
        public int Run(TreeNode input)
        {
            return FindBottomLeftValue(input);
        }

        public int FindBottomLeftValue(TreeNode root)
        {
            int level = 0;
            var value = 0;

            var stack = new Stack<TreeNode>();
            var current = root;

            do
            {
                while (current != null)
                {
                    stack.Push(current);

                    if (level < stack.Count)
                    {
                        level = stack.Count;
                        value = current.val;
                    }

                    current = current.left;
                }

                while (stack.Count > 0 && (stack.Peek().right == current || stack.Peek().right == null))
                {
                    current = stack.Pop();
                }

                current = stack.Count == 0 ? null : stack.Peek().right;

            } while (current != null);

            return value;
        }
    }
}
