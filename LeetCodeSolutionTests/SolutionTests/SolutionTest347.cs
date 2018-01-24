using System;
using System.Collections.Generic;
using LeetCodeSolution.Solutions;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public class SolutionTest347 : SolutionTestBase<Tuple<int[], int>, IList<int>>
    {
        public SolutionTest347() : base(new TaskSolution347())
        {
        }

        [Theory]
        [MemberData(nameof(GetTestCasesData))]
        public void CommonTests(Tuple<int[], int> input, IList<int> output)
        {
            RunTest(input, output);
        }

        public static IEnumerable<object[]> GetTestCasesData()
        {
            yield return PrepareInputOutput(new[] {1, 1, 1, 2, 2, 3}, 2, new List<int> {1, 2});

            yield return PrepareInputOutput(new[] {3, 1, 1, 1, 2, 2, 3, 2, 2}, 2, new List<int> {2, 1});

            yield return PrepareInputOutput(new[] {3, 1, 1, 1, 2, 2, 3, 2, 2}, 0, new List<int>());

            yield return PrepareInputOutput(new[] {5, 3, 1, 1, 1, 3, 73, 1}, 1, new List<int> {1});
        }
    }
}
