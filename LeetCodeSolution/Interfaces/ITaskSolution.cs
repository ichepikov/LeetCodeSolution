namespace LeetCodeSolution.Interfaces
{
    public interface ITaskSolution<in TInput, out TOutput>
    {
        TOutput Run(TInput input);
    }
}