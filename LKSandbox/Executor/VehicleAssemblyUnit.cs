using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Engine;
using LKSandbox.Models;

namespace LKSandbox.Executor
{
    internal class VehicleAssemblyUnit<Tvp, Tvd> where Tvp : IVehicleParts where Tvd : IVehicleDataProviders
    {
        public IVehicleEngineData VehicleBuilder(Tvp vehiclePartType, Tvd vehicleDataProviders)
        {
            var approvementData = vehiclePartType.HasApprovalToBuild(vehicleDataProviders.ApprovementDataProvider);
            var buildDurationData = vehiclePartType.BuildDuration(vehicleDataProviders.BuildDurationDataProvider);
            var totalCostData = vehiclePartType.TotalCost(vehicleDataProviders.TotalCostDataProvider);
            return new VehicleEngineData(approvementData, buildDurationData, totalCostData);
        }
    }
}
