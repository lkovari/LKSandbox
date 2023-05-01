using LKSandbox.Interfaces.Engine;
using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;
using LKSandbox.Models.Result;

namespace LKSandbox.Models.Engine
{
    public class EngineBuildDurationDataProducer : IEngineBuildDurationDataProducer
    {
        public decimal EngineSpecificBuildNumber { get; }

        private IDurationParameters _durationParameters;
        public IDurationParameters DurationParameters { get => _durationParameters; }

        public EngineBuildDurationDataProducer(decimal specificNumber, IDurationParameters durationParameters)
        {
            EngineSpecificBuildNumber = specificNumber;
            _durationParameters = durationParameters;
        }

        public IBuildDurationData ProduceData<T>(T durationParameters) where T : IDurationParameters
        {
            // apply the DurationParameters data as parameter to calculate Build Duration
            return new BuildDurationData("Name:" + _durationParameters.Name, _durationParameters.DateRange.End, 1965);
        }
    }
}
