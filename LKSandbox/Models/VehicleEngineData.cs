using LKSandbox.Interfaces.Engine;

namespace LKSandbox.Models
{
    internal class VehicleEngineData : IVehicleEngineData
    {
        public bool ApprovementData { get; }

        public decimal BuildDurationData { get; }

        public decimal TotalCostData { get; }

        public VehicleEngineData(bool approvementData, decimal buildDurationData, decimal totalCostData)
        {
            ApprovementData = approvementData;
            BuildDurationData = buildDurationData;
            TotalCostData = totalCostData;
        }
    }
}
