using LKSandbox.Interfaces.Engine;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Models
{
    internal class AssembledVehicleData : IAssembledVehicleData
    {
        public IApprovementData ApprovementData { get; }

        public IBuildDurationData BuildDurationData { get; }

        public ITotalCostData TotalCostData { get; }

        public AssembledVehicleData(IApprovementData approvementData, IBuildDurationData buildDurationData, ITotalCostData totalCostData)
        {
            ApprovementData = approvementData;
            BuildDurationData = buildDurationData;
            TotalCostData = totalCostData;
        }
    }
}
