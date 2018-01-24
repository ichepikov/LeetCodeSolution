using LeetCodeSolution.Solutions;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public class SolutionTest432
    {
        private readonly TaskSolution432 _taskSolution;
        public SolutionTest432()
        {
            _taskSolution = new TaskSolution432();
        }
        
        [Fact]
        public void Test1()
        {
            var testClass = _taskSolution.GetTestClass();

            testClass.Inc("a");
            testClass.Inc("b");
            testClass.Inc("b");
            testClass.Inc("c");
            testClass.Inc("c");
            testClass.Inc("c");
            testClass.Dec("b");
            testClass.Dec("b");

            var min1 = testClass.GetMinKey();
            Assert.Equal("a", min1);

            testClass.Dec("a");

            var max1 = testClass.GetMaxKey();
            Assert.Equal("c", max1);

            var min2 = testClass.GetMinKey();
            Assert.Equal("c", min2);
        }
    }
}
