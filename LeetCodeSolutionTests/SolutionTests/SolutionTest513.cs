using LeetCodeSolution.DataStructures;
using LeetCodeSolution.Solutions;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public class SolutionTest513 : SolutionTestBase<TreeNode, int>
    {
        public SolutionTest513() : base(new TaskSolution513())
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
