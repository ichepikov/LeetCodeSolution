using System;
using LeetCodeSolution.DataStructures;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Solutions
{
    public class TaskSolution160 : ITaskSolution<Tuple<ListNode, ListNode>, ListNode>
    {
        public ListNode Run(Tuple<ListNode, ListNode> input)
        {
            return GetIntersectionNode(input.Item1, input.Item2);
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            var currentA = headA;
            var currentB = headB;

            int switchCount = 2;

            while (switchCount != 0)
            {
                currentA = currentA.next;
                currentB = currentB.next;

                if (currentA == null)
                {
                    currentA = headB;
                    switchCount--;
                }

                if (currentB == null)
                {
                    currentB = headA;
                    switchCount--;
                }
            }

            while (currentA != currentB)
            {
                currentA = currentA.next;
                currentB = currentB.next;
            }

            return currentA;
        }
    }
}
