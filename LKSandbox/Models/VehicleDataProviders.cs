using LKSandbox.Interfaces;

namespace LKSandbox.Models
{
    internal class VehicleDataProviders : IVehicleDataProviders
    {
        public IApprovementDataProvider ApprovementDataProvider { get; }

        public IBuildDurationDataProvider BuildDurationDataProvider { get; }

        public ITotalCostDataProvider TotalCostDataProvider { get; }

        public VehicleDataProviders(IApprovementDataProvider approvementDataProvider, IBuildDurationDataProvider buildDurationDataProvider, ITotalCostDataProvider totalCostDataProvider)
        {
            ApprovementDataProvider = approvementDataProvider;
            BuildDurationDataProvider = buildDurationDataProvider;
            TotalCostDataProvider = totalCostDataProvider;
        }
    }
}
