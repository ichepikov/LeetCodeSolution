using System.Collections.Generic;
using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_233 : TaskTestBase<int, int>
    {
        public Test_233() : base(new Task_233(), new Task_233_Answer())
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
