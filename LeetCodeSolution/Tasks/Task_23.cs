using LeetCodeSolution.DataStructures;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Tasks
{
    public class Task_23 : ITask<ListNode[], ListNode>
    {
        public ListNode Run(ListNode[] input)
        {
            return MergeKLists(input);
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            var head = new ListNode(0);

            for (int i = 0; i < lists.Length; i++)
            {
                var result = head;
                var list1 = lists[i];
                var list2 = head.next;

                while (list2 != null || list1 != null)
                {
                    if (list2 == null)
                    {
                        result.next = list1;
                        list1 = null;
                    }
                    else if (list1 == null)
                    {
                        result.next = list2;
                        list2 = null;
                    }
                    else
                    {
                        if (list2.val > list1.val)
                        {
                            result.next = list1;
                            list1 = list1.next;
                        }
                        else
                        {
                            result.next = list2;
                            list2 = list2.next;
                        }
                    }

                    result = result.next;
                }
            }

            return head.next;
        }
    }
}
