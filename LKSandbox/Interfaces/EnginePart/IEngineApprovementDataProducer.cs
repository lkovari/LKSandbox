using LKSandbox.Interfaces.DataProducers;

namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineApprovementDataProducer : IApprovementDataProducer
    {
        public DateOnly Approvement { get; }
    }
}
