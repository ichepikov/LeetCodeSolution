using System.Collections.Generic;
using LeetCodeSolution.Interfaces;

namespace LeetCodeSolution.Solutions
{
    public class TaskSolution632 : ITaskSolution<IList<IList<int>>, int[]>
    {
        public int[] Run(IList<IList<int>> input)
        {
            return SmallestRange(input);
        }

        public int[] SmallestRange(IList<IList<int>> nums)
        {
            var currentCollection = new List<IEnumerator<int>>(nums.Count);
            foreach (var num in nums)
            {
                var enumerator = num.GetEnumerator();
                if (!enumerator.MoveNext())
                    return new[] {0, 0};

                InsertOrdered(currentCollection, enumerator);
            }

            var lastIndex = nums.Count - 1;

            var value = currentCollection[lastIndex].Current - currentCollection[0].Current;
            var result = new[] {currentCollection[0].Current, currentCollection[lastIndex].Current};

            while (true)
            {
                var minItem = currentCollection[0];
                currentCollection.RemoveAt(0);
                if (!minItem.MoveNext())
                    break;

                InsertOrdered(currentCollection, minItem);

                var newValue = currentCollection[lastIndex].Current - currentCollection[0].Current;
                if (newValue < value)
                {
                    value = newValue;
                    result = new[] {currentCollection[0].Current, currentCollection[lastIndex].Current};
                }
            }

            foreach (var item in currentCollection)
                item.Dispose();

            return result;
        }

        private void InsertOrdered(List<IEnumerator<int>> list, IEnumerator<int> item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Current > item.Current)
                {
                    list.Insert(i, item);
                    return;
                }
            }
            

            list.Add(item);
        }
    }
}
