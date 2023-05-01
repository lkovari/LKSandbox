using LKSandbox.Interfaces.DataProducers;

namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineBuildDurationDataProducer : IBuildDurationDataProducer
    {
        decimal EngineSpecificBuildNumber { get; }
    }
}
