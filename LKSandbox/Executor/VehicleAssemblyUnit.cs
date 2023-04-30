using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Engine;
using LKSandbox.Models;

namespace LKSandbox.Executor
{
    public class VehicleAssemblyUnit<Tvp, Tvd> where Tvp : IVehicleParts where Tvd : IVehicleDataProviders
    {
        public IAssembledVehicleData VehicleBuilder(Tvp vehiclePartType, Tvd vehicleDataProviders)
        {
            var approvementData = vehiclePartType.HasApprovalToBuild(vehicleDataProviders.ApprovementDataProvider);
            var buildDurationData = vehiclePartType.BuildDuration(vehicleDataProviders.BuildDurationDataProvider);
            var totalCostData = vehiclePartType.TotalCost(vehicleDataProviders.TotalCostDataProvider);
            return new AssembledVehicleData(approvementData, buildDurationData, totalCostData);
        }
    }
}
