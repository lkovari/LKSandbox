using LKSandbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models.Engine
{
    internal class EngineBuildDurationDataProvider : IBuildDurationDataProvider
    {
        public decimal EngineSpecificBuildNumber { get; }

        public EngineBuildDurationDataProvider(decimal specificNumber)
        {
            EngineSpecificBuildNumber = specificNumber;
        }

        public IBuildDurationData ProvideData()
        {
            return new BuildDurationData("Engine Build Duration", new DateOnly(), 1965);
        }
    }
}
