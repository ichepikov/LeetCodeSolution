using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_432
    {
        private readonly Task_432 _taskSolution;
        public Test_432()
        {
            _taskSolution = new Task_432();
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
