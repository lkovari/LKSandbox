using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IVehicleFramework
    {
        bool HasApprovalToBuild<T>(T approvementDataProvider) where T : IApprovementDataProvider;
        decimal BuildDuration<T>(T buildDurationDataProvider) where T : IBuildDurationDataProvider;
        decimal TotalCost<T>(T totalCostDataProvider) where T : ITotalCostDataProvider;
    }
}
