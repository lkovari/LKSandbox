using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Engine;
using LKSandbox.Models;

namespace LKSandbox.Executor
{
    public class VehicleAssemblyUnit<Tvp, Tvd> where Tvp : IVehiclePartType where Tvd : IVehicleDataProducers
    {
        public IAssembledVehicleData VehicleBuilder(Tvp vehiclePartType, Tvd vehicleDataProducers)
        {
            var approvementData = vehiclePartType.ApprovalToBuild(vehicleDataProducers.ApprovementDataProducer);
            var buildDurationData = vehiclePartType.BuildDuration(vehicleDataProducers.BuildDurationDataProducer);
            var totalCostData = vehiclePartType.TotalCost(vehicleDataProducers.TotalCostDataProducer);
            return new AssembledVehicleData(approvementData, buildDurationData, totalCostData);
        }
    }
}
