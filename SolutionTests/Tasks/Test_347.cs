using System;
using System.Collections.Generic;
using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_347 : TaskTestBase<Tuple<int[], int>, IList<int>>
    {
        public Test_347() : base(new Task_347())
        {
        }

        [Theory]
        [MemberData(nameof(GetTestCasesData))]
        public void EdgeCasesTests(Tuple<int[], int> input, IList<int> output)
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
