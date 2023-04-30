using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineBuildDurationDataProvider : IBuildDurationDataProvider
    {
        decimal EngineSpecificBuildNumber { get; }
    }
}
