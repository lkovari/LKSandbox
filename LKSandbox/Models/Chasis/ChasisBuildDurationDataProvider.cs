using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Chasis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models.Chasis
{
    internal class ChasisBuildDurationDataProvider : IChasisBuildDurationDataProvider
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
