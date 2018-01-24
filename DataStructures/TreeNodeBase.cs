using System.Diagnostics;

namespace DataStructures
{
    [DebuggerDisplay("{Value}")]
    public class TreeNodeBase<TValue>
    {
        public TValue Value { get; }
        public TreeNodeBase<TValue> Left { get; set; }
        public TreeNodeBase<TValue> Right { get; set; }

        public TreeNodeBase(TValue value)
        {
            Value = value;
        }
    }
}
