using LKSandbox.Interfaces;
using LKSandbox.Interfaces.DataProducers;

namespace LKSandbox.Models
{
    public class VehicleDataProducers : IVehicleDataProducers
    {
        public IApprovementDataProducer ApprovementDataProducer { get; }

        public IBuildDurationDataProducer BuildDurationDataProducer { get; }

        public ITotalCostDataProducer TotalCostDataProducer { get; }

        public VehicleDataProducers(IApprovementDataProducer approvementDataProducer, IBuildDurationDataProducer buildDurationDataProducer, ITotalCostDataProducer totalCostDataProducer)
        {
            ApprovementDataProducer = approvementDataProducer;
            BuildDurationDataProducer = buildDurationDataProducer;
            TotalCostDataProducer = totalCostDataProducer;
        }
    }
}
