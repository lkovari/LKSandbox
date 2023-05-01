namespace LKSandbox.Interfaces.Result
{
    public interface IApprovementData : IResultData
    {
        DateOnly Date { get; }
        bool IsApproved { get; }
    }
}
