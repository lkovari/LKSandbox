using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IEngineServiceType : IVehicleFramework
    {
        string Code { get; }
        string Name { get; }
        string Description { get; }
    }
}
