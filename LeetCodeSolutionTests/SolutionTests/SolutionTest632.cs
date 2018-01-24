using System.Collections.Generic;
using LeetCodeSolution.Solutions;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public class SolutionTest632 : SolutionTestBase<IList<IList<int>>, int[]>
    {
        public SolutionTest632() : base(new TaskSolution632())
        {
        }

        [Theory]
        [MemberData(nameof(GetTestCasesData))]
        public void CommonTests(IList<IList<int>> input, int[] output)
        {
            RunTest(input, output);
        }

        public static IEnumerable<object[]> GetTestCasesData()
        {
            yield return PrepareInputOutput(new List<IList<int>>
            {
                new List<int> {4, 10, 15, 24, 26},
                new List<int> {0, 9, 12, 20},
                new List<int> {5, 18, 22, 30}
            }, new[] { 20, 24 });

            yield return PrepareInputOutput(new List<IList<int>>
            {
                new List<int> {1, 2, 3},
                new List<int> {1, 2, 3},
                new List<int> {1, 2, 3}
            }, new[] { 1, 1 });

            yield return PrepareInputOutput(new List<IList<int>>
            {
                new List<int> {-5,-4,-3,-2,-1,1},
                new List<int> { 1, 2, 3, 4, 5 }
            }, new[] { 1, 1 });
        }
    }
}
