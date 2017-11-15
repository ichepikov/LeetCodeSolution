using System.Collections.Generic;
using LeetCodeSolution.DataStructures;

namespace LeetCodeSolution.Algorithms
{
    //Depth-first order
    //Breadth-first order
    public static class BinaryTreeTraversalExtension
    {
        public static IEnumerable<TreeNodeBase<TValue, TNode>> TraversalDepthFirstWithStack<TValue, TNode>(
            TreeNodeBase<TValue, TNode> root)
            where TNode : TreeNodeBase<TValue, TNode>
        {
            var stack = new Stack<TreeNodeBase<TValue, TNode>>();
            TreeNodeBase<TValue, TNode> current = root;
            do
            {
                while (current != null)
                {
                    yield return current;
                    stack.Push(current);
                    current = current.left;
                }

                while (stack.Count > 0 && (stack.Peek().right == current || stack.Peek().right == null))
                {
                    current = stack.Pop();
                }

                if (stack.Count == 0)
                    current = null;
                else
                    current = stack.Peek().right;
            } while (current != null);
        }
    }
}
