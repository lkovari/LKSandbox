using LKSandbox.Interfaces.DataProducers;

namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisTotalCostDataProducer : ITotalCostDataProducer
    {
        DateOnly Installation { get; }
    }
}
