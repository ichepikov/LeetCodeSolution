using System;
using System.Collections.Generic;
using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_188
    {
        private readonly Task_188 _tasksolution;

        public Test_188()
        {
            _tasksolution = new Task_188();
        }

        [Theory]
        [MemberData(nameof(GetEdgeCasesData))]
        public void EdgeCasesTests(Tuple<int, int[]> input, int output)
        {
            var result = _tasksolution.Run(input);
            Assert.Equal(output, result);
        }

        [Theory]
        [MemberData(nameof(GetCommonCasesData))]
        public void CommonTests(Tuple<int, int[]> input, int output)
        {
            var result = _tasksolution.Run(input);
            Assert.Equal(output, result);
        }

        public static IEnumerable<object[]> GetEdgeCasesData()
        {
            yield return GetDataItem(0, new[] {10, 100, 5, 200}, 0);

            yield return GetDataItem(1, new int[0], 0);

            yield return GetDataItem(1, new[] {10}, 0);

            yield return GetDataItem(1, new[] {10, 10}, 0);
        }

        public static IEnumerable<object[]> GetCommonCasesData()
        {
            yield return GetDataItem(1, new[] {10, 100, 5, 200}, 195);

            yield return GetDataItem(2, new[] {10, 100, 5, 200}, 285);

            yield return GetDataItem(3, new[] {10, 100, 5, 200}, 285);

            yield return GetDataItem(2, new[] {1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9}, 17);

            yield return GetDataItem(2, new[] {5, 2, 3, 2, 6, 6, 2, 9, 1, 0, 7, 4, 5, 0}, 14);
        }

        private static object[] GetDataItem(int k, int[] prices, int output)
        {
            return new object[]
            {
                new Tuple<int, int[]>(k, prices),
                output
            };
        }
    }
}
