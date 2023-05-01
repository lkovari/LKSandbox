using LKSandbox.Interfaces.DataProducers;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Interfaces
{
    public interface IVehiclePartType
    {
        IResultData HasApprovalToBuild<T>(T approvementDataProducer) where T : IApprovementDataProducer;
        IResultData BuildDuration<T>(T buildDurationDataProducer) where T : IBuildDurationDataProducer;
        IResultData TotalCost<T>(T totalCostDataProducer) where T : ITotalCostDataProducer;
    }
}
