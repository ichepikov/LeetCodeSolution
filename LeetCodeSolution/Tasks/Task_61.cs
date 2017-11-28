using System;
using LeetCodeSolution.DataStructures;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_61 : ITask<Tuple<ListNode, int>, ListNode>
    {
        public ListNode Run(Tuple<ListNode, int> input)
        {
            return RotateRight(input.Item1, input.Item2);
        }

        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;

            var count = 1;
            var tail = head;
            while (tail.next != null)
            {
                count++;
                tail = tail.next;
            }

            k = k % count;

            if (k == 0)
                return head;

            tail.next = head;

            var current = head;
            for (int i = 1; i < count - k; i++)
                current = current.next;

            head = current.next;

            current.next = null;

            return head;
        }
    }
}
