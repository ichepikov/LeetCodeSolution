using System;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Task_669 : ITask<Tuple<TreeNode, int, int>, TreeNode>
    {
        public TreeNode Run(Tuple<TreeNode, int, int> input)
        {
            return TrimBST(input.Item1, input.Item2, input.Item3);
        }

        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return null;

            if (root.val < L)
                return TrimBST(root.right, L, R);

            if (root.val > R)
                return TrimBST(root.left, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);

            return root;
        }
    }
}
