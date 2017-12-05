using System.Collections.Generic;
using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_342 : TaskTestBase<int, bool>
    {
        public Test_342() : base(new Task_342())
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
