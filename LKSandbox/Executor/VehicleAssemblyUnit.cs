using LKSandbox.Interfaces;
using LKSandbox.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Executor
{
    internal class VehicleAssemblyUnit<T> where T : IVehicleParts //,IVehicleAssemblyUnit<T>
    {
        public IVehicleEngineData VehicleBuilder(T item)
        {
            IEngineApprovementDataProvider engineApprovementDataProvider = new EngineApprovementDataProvider(new DateOnly());
            IBuildDurationDataProvider engineBuildDurationDataProvider = new EngineBuildDurationDataProvider(394759);
            IEngineTotalCostDataProvider engineTotalCostDataProvider = new EngineTotalCostDataProvider(new DateOnly());
            var engineApprovementData = item.HasApprovalToBuild(engineApprovementDataProvider);
            var engineBuildDurationData = item.BuildDuration(engineBuildDurationDataProvider);
            var engineTotalCostData = item.TotalCost(engineTotalCostDataProvider);
            return new VehicleEngineData(engineApprovementData, engineBuildDurationData, engineTotalCostData);
        }
    }
}
