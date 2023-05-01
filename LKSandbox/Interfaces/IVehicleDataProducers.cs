using LKSandbox.Interfaces.DataProducers;

namespace LKSandbox.Interfaces
{
    public interface IVehicleDataProducers
    {
        IApprovementDataProducer ApprovementDataProducer { get; }
        IBuildDurationDataProducer BuildDurationDataProducer { get; }
        ITotalCostDataProducer TotalCostDataProducer { get; }
    }
}
