namespace LKSandbox.Interfaces
{
    public interface IVehicleParts
    {
        bool HasApprovalToBuild<T>(T approvementDataProvider) where T : IApprovementDataProvider;
        decimal BuildDuration<T>(T buildDurationDataProvider) where T : IBuildDurationDataProvider;
        decimal TotalCost<T>(T totalCostDataProvider) where T : ITotalCostDataProvider;
    }
}
