using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IChasisServiceType : IVehicleFramework
    {
        string Name { get; }
        string Description { get; }
        string ChasisNumber { get; }
    }
}
