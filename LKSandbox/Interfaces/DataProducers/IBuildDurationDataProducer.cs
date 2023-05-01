using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Interfaces.DataProducers
{
    public interface IBuildDurationDataProducer
    {
        public IDurationParameters DurationParameters { get; }
        public IBuildDurationData ProduceData<T>(T durationParameters) where T : IDurationParameters;
    }
}
