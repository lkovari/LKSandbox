namespace LKSandbox.Interfaces
{
    public interface IVehicleDataProviders
    {
        IApprovementDataProvider ApprovementDataProvider { get; }
        IBuildDurationDataProvider BuildDurationDataProvider { get; }
        ITotalCostDataProvider TotalCostDataProvider { get; }
    }
}
