namespace LKSandbox.Interfaces
{
    internal interface IApprovementData
    {
        DateOnly Date { get; }
        bool IsApproved { get; }
    }
}
