using LKSandbox.Interfaces.Engine;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Models
{
    internal class AssembledVehicleData : IAssembledVehicleData
    {
        public IResultData ApprovementData { get; }

        public IResultData BuildDurationData { get; }

        public IResultData TotalCostData { get; }

        public AssembledVehicleData(IResultData approvementData, IResultData buildDurationData, IResultData totalCostData)
        {
            ApprovementData = approvementData;
            BuildDurationData = buildDurationData;
            TotalCostData = totalCostData;
        }
    }
}
