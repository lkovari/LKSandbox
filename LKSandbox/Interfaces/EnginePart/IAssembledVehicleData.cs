using LKSandbox.Interfaces.Result;

namespace LKSandbox.Interfaces.Engine
{
    public interface IAssembledVehicleData
    {
        IResultData ApprovementData { get; }
        IResultData BuildDurationData { get; }
        IResultData TotalCostData { get; }
    }
}
