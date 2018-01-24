using System.Collections.Generic;
using LeetCodeSolution.Solutions;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public class SolutionTest342 : SolutionTestBase<int, bool>
    {
        public SolutionTest342() : base(new TaskSolution342())
        {
        }

        [Theory]
        [MemberData(nameof(GetEdgeCasesData))]
        public void CommonTests(int input, bool output)
        {
            RunTest(input, output);
        }

        public static IEnumerable<object[]> GetEdgeCasesData()
        {
            yield return PrepareInputOutput(0, false);

            yield return PrepareInputOutput(5, false);

            yield return PrepareInputOutput(13267, false);

            yield return PrepareInputOutput(1, true);

            yield return PrepareInputOutput(4, true);

            yield return PrepareInputOutput(17, false);
            
            yield return PrepareInputOutput(8, false);

            yield return PrepareInputOutput(16, true);

            yield return PrepareInputOutput(256, true);

            yield return PrepareInputOutput(16777216, true);
        }
    }
}
