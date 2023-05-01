using LKSandbox.Interfaces.DataProducers;

namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineTotalCostDataProducer : ITotalCostDataProducer
    {
        DateOnly Installation { get; }
    }
}
