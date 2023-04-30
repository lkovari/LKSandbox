using LKSandbox.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models
{
    internal class VehicleEngineData : IVehicleEngineData
    {
        public bool ApprovementData { get; }

        public decimal BuildDurationData { get; }

        public decimal TotalCostData { get; }

        public VehicleEngineData(bool approvementData, decimal buildDurationData, decimal totalCostData)
        {
            ApprovementData = approvementData;
            BuildDurationData = buildDurationData;
            TotalCostData = totalCostData;
        }
    }
}
