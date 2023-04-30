using LKSandbox.Interfaces.Engine;

namespace LKSandbox.Models
{
    internal class AssembledVehicleData : IAssembledVehicleData
    {
        public bool ApprovementData { get; }

        public decimal BuildDurationData { get; }

        public decimal TotalCostData { get; }

        public AssembledVehicleData(bool approvementData, decimal buildDurationData, decimal totalCostData)
        {
            ApprovementData = approvementData;
            BuildDurationData = buildDurationData;
            TotalCostData = totalCostData;
        }
    }
}
