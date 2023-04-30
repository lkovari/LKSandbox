using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IVehicleEngineData
    {
        bool ApprovementData { get; }
        decimal BuildDurationData { get; }
        decimal TotalCostData { get; }
    }
}
