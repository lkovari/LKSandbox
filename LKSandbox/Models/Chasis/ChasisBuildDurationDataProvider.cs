using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Chasis;

namespace LKSandbox.Models.Chasis
{
    public class ChasisBuildDurationDataProvider : IChasisBuildDurationDataProvider
    {
        public decimal ChasisSpecificBuildNumber { get; }


        public ChasisBuildDurationDataProvider(decimal specificNumber)
        {
            ChasisSpecificBuildNumber = specificNumber;
        }

        public IBuildDurationData ProvideData()
        {
            return new BuildDurationData("Chasis Build Duration", new DateOnly(), 1966);
        }
    }
}
