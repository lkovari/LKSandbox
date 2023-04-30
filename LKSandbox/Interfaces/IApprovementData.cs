namespace LKSandbox.Interfaces
{
    public interface IApprovementData
    {
        DateOnly Date { get; }
        bool IsApproved { get; }
    }
}
