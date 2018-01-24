using System.Collections.Generic;
using DataStructures;

namespace Algorithms.Trees
{
    //Depth-first order
    //Breadth-first order
    public static class BinaryTreeTraversalExtension
    {
        public static IEnumerable<TreeNodeBase<TValue>> TraversalDepthFirstWithStack<TValue>(
            TreeNodeBase<TValue> root)
        {
            var stack = new Stack<TreeNodeBase<TValue>>();
            TreeNodeBase<TValue> current = root;
            do
            {
                while (current != null)
                {
                    yield return current;
                    stack.Push(current);
                    current = current.Left;
                }

                while (stack.Count > 0 && (stack.Peek().Right == current || stack.Peek().Right == null))
                {
                    current = stack.Pop();
                }

                if (stack.Count == 0)
                    current = null;
                else
                    current = stack.Peek().Right;
            } while (current != null);
        }
    }
}
