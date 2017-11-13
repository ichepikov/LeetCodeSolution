namespace LeetCodeSolution.Interfaces
{
    public interface ITask<in TInput, out TOutput>
    {
        TOutput Run(TInput input);
    }
}