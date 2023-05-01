using LKSandbox.Interfaces.Result;

namespace LKSandbox.Interfaces.Engine
{
    public interface IAssembledVehicleData
    {
        IApprovementData ApprovementData { get; }
        IBuildDurationData BuildDurationData { get; }
        ITotalCostData TotalCostData { get; }
    }
}
