using LKSandbox.Interfaces.DataProducers;

namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisApprovementDataProducer : IApprovementDataProducer
    {
        public DateOnly Approvement { get; }
    }
}
