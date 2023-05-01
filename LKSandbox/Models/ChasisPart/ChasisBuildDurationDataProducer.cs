using LKSandbox.Interfaces.Chasis;
using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;
using LKSandbox.Models.Result;

namespace LKSandbox.Models.Chasis
{
    public class ChasisBuildDurationDataProducer : IChasisBuildDurationDataProducer
    {
        public decimal ChasisSpecificBuildNumber { get; }

        public IDurationParameters DurationParameters { get; }

        public ChasisBuildDurationDataProducer(decimal specificNumber, IDurationParameters durationParameters)
        {
            ChasisSpecificBuildNumber = specificNumber;
            DurationParameters = durationParameters;
        }

        public IResultData ProduceData<T>(T durationParameters) where T : IDurationParameters
        {
            // apply the DurationParameters data as parameter to calculate Build Duration
            return new BuildDurationData(durationParameters.Name, durationParameters.DateRange.End, 1966);
        }
    }
}
