using System;
using System.Collections.Generic;
using LeetCodeSolution.Solutions;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public class SolutionTest7 : SolutionTestBase<int, int>
    {
        public SolutionTest7() : base(new TaskSolution7())
        {
        }

        [Theory]
        [MemberData(nameof(GetTestCasesData))]
        public void CommonTests(int input, int output)
        {
            RunTest(input, output);
        }

        public static IEnumerable<object[]> GetTestCasesData()
        {
            yield return PrepareInputOutput(0, 0);
            yield return PrepareInputOutput(1, 1);
            yield return PrepareInputOutput(-1, -1);

            yield return PrepareInputOutput(120, 21);
            yield return PrepareInputOutput(1020, 201);

            yield return PrepareInputOutput(-123, -321);

            yield return PrepareInputOutput(1534236469, 0);

            yield return PrepareInputOutput(Int32.MaxValue, 0);
            yield return PrepareInputOutput(Int32.MinValue, 0);
        }
    }
}
