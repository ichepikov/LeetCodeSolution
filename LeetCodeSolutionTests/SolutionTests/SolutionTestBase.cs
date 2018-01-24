using System;
using System.IO;
using LeetCodeSolution.Interfaces;
using Xunit;

namespace LeetCodeSolutionTests.SolutionTests
{
    public abstract class SolutionTestBase<TInput, TOutput>
    {
        protected readonly ITaskSolution<TInput, TOutput> TaskSolutionSolution;
        protected readonly ITaskSolution<TInput, TOutput> TestValidator;

        protected SolutionTestBase(ITaskSolution<TInput, TOutput> testTaskSolution, ITaskSolution<TInput, TOutput> testValidator) : this(testTaskSolution)
        {
            TestValidator = testValidator;
        }

        protected SolutionTestBase(ITaskSolution<TInput, TOutput> testTaskSolution)
        {
            TaskSolutionSolution = testTaskSolution;
        }

        protected void RunTest(TInput input, TOutput output)
        {
            var result = TaskSolutionSolution.Run(input);
            Assert.Equal(output, result);
        }

        protected void RunTest(TInput input)
        {
            if (TestValidator == null)
                throw new InvalidOperationException("output is not provided");

            var output = TestValidator.Run(input);
            RunTest(input, output);
        }

        protected static object[] PrepareInput(TInput input1)
        {
            return new object[]
            {
                input1
            };
        }

        protected static object[] PrepareInput<T1, T2>(T1 input1, T2 input2)
        {
            ValidateOutputType<T1, T2>();

            return new object[]
            {
                new Tuple<T1, T2>(input1, input2)
            };
        }

        protected static object[] PrepareInputOutput(TInput input1, TOutput output)
        {
            return new object[]
            {
                input1,
                output
            };
        }

        protected static object[] PrepareInputOutput<T1, T2>(T1 input1, T2 input2, TOutput output)
        {
            ValidateOutputType<T1, T2>();

            return new object[]
            {
                new Tuple<T1, T2>(input1, input2),
                output
            };
        }

        private static void ValidateOutputType<T1, T2>()
        {
            if (typeof(TInput) != typeof(Tuple<T1, T2>))
                throw new InvalidDataException();
        }
    }
}
