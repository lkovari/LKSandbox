using LKSandbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models
{
    internal class EngineBuildDurationDataProvider : IBuildDurationDataProvider
    {
        public decimal EngineSpecificBaseNumber { get; }

        public EngineBuildDurationDataProvider(decimal specificNumber)
        {
            EngineSpecificBaseNumber = specificNumber;
        }

        public IBuildDurationData ProvideData()
        {
            return new BuildDurationData("Engine Build Duration", new DateOnly(), 1965);
        }
    }
}
