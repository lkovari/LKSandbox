using LKSandbox.Interfaces.DataProducers;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Interfaces
{
    public interface IVehiclePartType
    {
        IApprovementData ApprovalToBuild<T>(T approvementDataProducer) where T : IApprovementDataProducer;
        IBuildDurationData BuildDuration<T>(T buildDurationDataProducer) where T : IBuildDurationDataProducer;
        ITotalCostData TotalCost<T>(T totalCostDataProducer) where T : ITotalCostDataProducer;
    }
}
