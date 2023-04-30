namespace LKSandbox.Interfaces
{
    internal interface IVehicleDataProviders
    {
        IApprovementDataProvider ApprovementDataProvider { get; }
        IBuildDurationDataProvider BuildDurationDataProvider { get; }
        ITotalCostDataProvider TotalCostDataProvider { get; }
    }
}
