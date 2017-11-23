using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolution.DataStructures;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_124 : ITask<TreeNode, int>
    {
        public int Run(TreeNode input)
        {
            return MaxPathSum(input);
        }

        public int MaxPathSum(TreeNode root)
        {
            CalculateSubTree(root, out int? withRoot, out int? withoutRoot);

            return Max(withRoot, withoutRoot) ?? 0;
        }

        private void CalculateSubTree(TreeNode node, out int? halfPath, out int? fullPath)
        {
            if (node == null)
            {
                halfPath = null;
                fullPath = null;
            }
            else
            {
                CalculateSubTree(node.left, out int? leftHalf, out int? leftFull);
                CalculateSubTree(node.right, out int? rightHalf, out int? rightFull);

                halfPath = (Max(leftHalf, rightHalf) ?? 0) + node.val;
                fullPath = Max(Max(leftFull, rightFull), (leftHalf ?? 0) + (rightHalf ?? 0) + node.val);
            }
        }

        private int? Max(int? a, int? b)
        {
            if (!a.HasValue && !b.HasValue)
                return null;

            if (!a.HasValue)
                return b.Value;

            if (!b.HasValue)
                return a.Value;

            return Math.Max(a.Value, b.Value);
        }
    }
}
