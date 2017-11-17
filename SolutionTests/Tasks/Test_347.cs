using System;
using System.Collections.Generic;
using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_347
    {
        private readonly Task_347 _tasksolution;

        public Test_347()
        {
            _tasksolution = new Task_347();
        }

        [Theory]
        [MemberData(nameof(GetTestCasesData))]
        public void EdgeCasesTests(Tuple<int[], int> input, IList<int> output)
        {
            var result = _tasksolution.Run(input);
            Assert.Equal(output, result);
        }

        public static IEnumerable<object[]> GetTestCasesData()
        {
            yield return GetDataItem(new[] {1, 1, 1, 2, 2, 3}, 2, new List<int> {1, 2});

            yield return GetDataItem(new[] {3, 1, 1, 1, 2, 2, 3, 2, 2}, 2, new List<int> {2, 1});

            yield return GetDataItem(new[] {3, 1, 1, 1, 2, 2, 3, 2, 2}, 0, new List<int>());

            yield return GetDataItem(new[] {5, 3, 1, 1, 1, 3, 73, 1}, 1, new List<int> {1});
        }

        private static object[] GetDataItem(int[] items, int count, IList<int> output)
        {
            return new object[]
            {
                new Tuple<int[], int>(items, count),
                output
            };
        }
    }
}
