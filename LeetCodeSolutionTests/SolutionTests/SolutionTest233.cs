using System.Collections.Generic;
using LeetCodeSolution.Solutions;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public class SolutionTest233 : SolutionTestBase<int, int>
    {
        public SolutionTest233() : base(new TaskSolution233(), new TaskAnswer233())
        {
        }

        [Theory]
        [MemberData(nameof(GetCommonCasesData))]
        public void CommonTests(int input)
        {
            RunTest(input);
        }

        public static IEnumerable<object[]> GetCommonCasesData()
        {
            yield return PrepareInput(-1);
            yield return PrepareInput(0);
            yield return PrepareInput(1);
            yield return PrepareInput(10);
            yield return PrepareInput(100);
            yield return PrepareInput(1000);
            yield return PrepareInput(2);
            yield return PrepareInput(20);
            yield return PrepareInput(21);
            yield return PrepareInput(22);
            yield return PrepareInput(13);
            yield return PrepareInput(105);
            yield return PrepareInput(999);
            yield return PrepareInput(12);
            yield return PrepareInput(23);
            yield return PrepareInput(223);
            yield return PrepareInput(123);
            yield return PrepareInput(2314);
            yield return PrepareInput(234561);
            yield return PrepareInput(23409);
            yield return PrepareInput(38622);
        }
    }
}
