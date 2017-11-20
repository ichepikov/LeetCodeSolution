using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_233
    {
        private readonly Task_233 _taskSolution;

        private readonly Task_233_Answer _taskSolutionAnswer;

        public Test_233()
        {
            _taskSolutionAnswer = new Task_233_Answer();
            _taskSolution = new Task_233();
        }

        [Theory]
        [MemberData(nameof(GetCommonCasesData))]
        public void CommonTests(int input)
        {
            var result = _taskSolution.Run(input);
            var output = _taskSolutionAnswer.Run(input);
            Assert.Equal(output, result);
        }

        public static IEnumerable<object[]> GetCommonCasesData()
        {
            yield return GetDataItem(-1);
            yield return GetDataItem(0);
            yield return GetDataItem(1);
            yield return GetDataItem(10);
            yield return GetDataItem(100);
            yield return GetDataItem(1000);
            yield return GetDataItem(2);
            yield return GetDataItem(20);
            yield return GetDataItem(21);
            yield return GetDataItem(22);
            yield return GetDataItem(13);
            yield return GetDataItem(105);
            yield return GetDataItem(999);
            yield return GetDataItem(12);
            yield return GetDataItem(23);
            yield return GetDataItem(223);
            yield return GetDataItem(123);
            yield return GetDataItem(2314);
            yield return GetDataItem(234561);
            yield return GetDataItem(23409);
            yield return GetDataItem(38622);
        }

        private static object[] GetDataItem(int k)
        {
            return new object[]
            {
                k
            };
        }
    }
}
