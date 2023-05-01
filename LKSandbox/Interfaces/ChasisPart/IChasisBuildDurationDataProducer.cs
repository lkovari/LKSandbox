using LKSandbox.Interfaces.DataProducers;

namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisBuildDurationDataProducer : IBuildDurationDataProducer
    {
        decimal ChasisSpecificBuildNumber { get; }
    }
}
