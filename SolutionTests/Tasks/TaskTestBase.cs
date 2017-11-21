using System;
using System.IO;
using LeetCodeSolution.Interfaces;
using Xunit;

namespace SolutionTests.Tasks
{
    public abstract class TaskTestBase<TInput, TOutput>
    {
        private readonly ITask<TInput, TOutput> _taskSolution;
        private readonly ITask<TInput, TOutput> _testValidator;

        protected TaskTestBase(ITask<TInput, TOutput> testTask, ITask<TInput, TOutput> testValidator) : this(testTask)
        {
            _testValidator = testValidator;
        }

        protected TaskTestBase(ITask<TInput, TOutput> testTask)
        {
            _taskSolution = testTask;
        }

        protected void RunTest(TInput input, TOutput output)
        {
            var result = _taskSolution.Run(input);
            Assert.Equal(output, result);
        }

        protected void RunTest(TInput input)
        {
            if (_testValidator == null)
                throw new InvalidOperationException("output is not provided");

            var output = _testValidator.Run(input);
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
