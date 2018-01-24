using System;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Solutions
{
    public class TaskSolution4 : ITaskSolution<Tuple<int[], int[]>, double>
    {
        public double Run(Tuple<int[], int[]> input)
        {
            return FindMedianSortedArrays(input.Item1, input.Item2);
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int index1 = 0;
            int index2 = 0;

            if (nums1.Length != 0 && nums2.Length != 0)
            {
                var midIndex1 = (nums1.Length - 1) / 2;
                var midIndex2 = (nums2.Length - 1) / 2;

                if (nums1[midIndex1] < nums2[midIndex2])
                    index1 = midIndex1;
                else
                    index2 = midIndex2;
            }

            var countCombine = nums1.Length + nums2.Length;
            var countCombineHalf = countCombine / 2;
            var isOdd = countCombine % 2 == 0;

            var prev = 0;
            var cur = 0;

            while (index1 + index2 - 1 < countCombineHalf)
            {
                prev = cur;
                if (nums1.Length <= index1)
                {
                    cur = nums2[index2];
                    index2++;
                }
                else if (nums2.Length <= index2)
                {
                    cur = nums1[index1];
                    index1++;
                }
                else if (nums1[index1] < nums2[index2])
                {
                    cur = nums1[index1];
                    index1++;
                }
                else
                {
                    cur = nums2[index2];
                    index2++;
                }
            }

            if (!isOdd)
                return cur;

            return (double) (prev + cur) / 2;
        }
    }
}
