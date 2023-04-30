using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IVehicleDataProviders
    {
        IApprovementDataProvider ApprovementDataProvider { get; }
        IBuildDurationDataProvider BuildDurationDataProvider { get; }
        ITotalCostDataProvider TotalCostDataProvider { get; }
    }
}
