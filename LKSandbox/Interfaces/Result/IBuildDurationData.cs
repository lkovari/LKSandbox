namespace LKSandbox.Interfaces.Result
{
    public interface IBuildDurationData : IResultData
    {
        DateOnly BuildDate { get; }
        decimal Days { get; }
    }
}
