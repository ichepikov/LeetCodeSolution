using System;
using System.Collections.Generic;
using LeetCodeSolution.Solutions;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public class SolutionTest4 : SolutionTestBase<Tuple<int[], int[]>, double>
    {
        public SolutionTest4() : base(new TaskSolution4())
        {
        }

        [Theory]
        [MemberData(nameof(GetCommonCasesData))]
        public void CommonTests(Tuple<int[], int[]> input, double output)
        {
            RunTest(input, output);
        }

        [Fact]
        public void FailOnEmptyArrays()
        {
            var exception = Record.Exception(() =>
            {
                RunTest(new Tuple<int[], int[]>(new int[0], new int[0]), 0);
            });
            
            Assert.NotNull(exception);
        }

        public static IEnumerable<object[]> GetCommonCasesData()
        {
            yield return PrepareInputOutput(new[] {1}, new int[0], 1);
            yield return PrepareInputOutput(new int[0], new[] {1}, 1);
            yield return PrepareInputOutput(new[] { 1 }, new[] { 1 }, 1);
            
            yield return PrepareInputOutput(new[] {1, 2, 5}, new[] {1, 2, 5}, 2);

            yield return PrepareInputOutput(new[] {1, 2, 5}, new[] {10, 12, 15, 16}, 10);

            yield return PrepareInputOutput(new[] {10}, new[] {15}, 12.5);

            yield return PrepareInputOutput(new[] {0, 1, 10}, new[] {15, 22, 77}, 12.5);

            yield return PrepareInputOutput(new[] {11}, new[] {1, 15}, 11);

            yield return PrepareInputOutput(new[] {1, 3}, new[] {2}, 2);

            yield return PrepareInputOutput(new[] {1, 3}, new[] {2, 4}, 2.5);

            yield return PrepareInputOutput(new[] {1}, new[] {2, 4, 5, 6, 8, 9, 22, 999}, 6);

            yield return PrepareInputOutput(new[] {1, 3, 6, 9, 22, 55, 88, 197},
                new[] {2, 4, 5, 8, 9, 111, 468, 989, 2586}, 9);
        }
    }
}
