using LeetCodeSolution.DataStructures;
using LeetCodeSolution.Tasks;
using Xunit;

namespace SolutionTests.Tasks
{
    public class Test_513 : TaskTestBase<TreeNode, int>
    {
        public Test_513() : base(new Task_513())
        {
        }

        [Fact]
        public void TestMethod()
        {
            var rootNode = new TreeNode(100)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(1) {left = new TreeNode(98), right = new TreeNode(22)},
                    right = new TreeNode(5) {left = new TreeNode(198), right = new TreeNode(122)}
                },
                right = new TreeNode(101)
                {
                    right = new TreeNode(102)
                    {
                        right = new TreeNode(103)
                        {
                            left = new TreeNode(104)
                        }
                    }
                }
            };

            RunTest(rootNode, 104);
        }
    }
}
