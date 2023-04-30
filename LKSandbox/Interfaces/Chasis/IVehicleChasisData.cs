using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces.Chasis
{
    internal interface IVehicleChasisData
    {
        bool ApprovementData { get; }
        decimal BuildDurationData { get; }
        decimal TotalCostData { get; }
    }
}
