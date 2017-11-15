using System.Diagnostics;

namespace LeetCodeSolution.DataStructures
{
    [DebuggerDisplay("{val}")]
    public class TreeNodeBase<TValue, TNode> where TNode : TreeNodeBase<TValue, TNode>
    {
        public TValue val;
        public TNode left;
        public TNode right;

        public TreeNodeBase(TValue x)
        {
            val = x;
        }
    }
}
