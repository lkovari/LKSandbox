using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IVehicleAssemblyUnit<T> where T : IVehicleFramework
    {
        public IVehicleEngineData VehicleBuilder<T>(T vehicleFramework) where T : IVehicleFramework;
    }
}
