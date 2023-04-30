using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IEngineServiceType : IVehicleParts
    {
        string Code { get; }
        string Name { get; }
        string Description { get; }
    }
}
