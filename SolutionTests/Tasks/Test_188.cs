using System;
using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_188
    {
        [Fact]
        public void TestMethodNoTransactions()
        {
            var tasksolution = new Task_188();
            int result = tasksolution.Run(new Tuple<int, int[]>(0, new[] {10, 100, 5, 200}));

            Assert.Equal(0, result);
        }

        [Fact]
        public void TestMethodEmptyStock()
        {
            var tasksolution = new Task_188();
            int result = tasksolution.Run(new Tuple<int, int[]>(1, new int[0]));

            Assert.Equal(0, result);
        }

        [Fact]
        public void TestMethodOneStock()
        {
            var tasksolution = new Task_188();
            int result = tasksolution.Run(new Tuple<int, int[]>(1, new[] {10}));

            Assert.Equal(0, result);
        }

        [Fact]
        public void TestMethodNoChanges()
        {
            var tasksolution = new Task_188();
            int result = tasksolution.Run(new Tuple<int, int[]>(1, new[] {10, 10}));

            Assert.Equal(0, result);
        }

        [Fact]
        public void TestMethod()
        {
            var tasksolution = new Task_188();
            int result = tasksolution.Run(new Tuple<int, int[]>(1, new[] {10, 100, 5, 200}));

            Assert.Equal(195, result);
        }

        [Fact]
        public void TestMethod2()
        {
            var tasksolution = new Task_188();
            int result = tasksolution.Run(new Tuple<int, int[]>(2, new[] {10, 100, 5, 200}));

            Assert.Equal(285, result);
        }

        [Fact]
        public void TestMethod3()
        {
            var tasksolution = new Task_188();
            int result = tasksolution.Run(new Tuple<int, int[]>(2, new[] {1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9}));

            Assert.Equal(17, result);
        }

        [Fact]
        public void TestMethod4()
        {
            var tasksolution = new Task_188();
            int result = tasksolution.Run(new Tuple<int, int[]>(2, new[] {5, 2, 3, 2, 6, 6, 2, 9, 1, 0, 7, 4, 5, 0}));

            Assert.Equal(14, result);
        }
    }
}
