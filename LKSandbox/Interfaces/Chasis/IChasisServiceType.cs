using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisServiceType : IVehicleParts
    {
        string Name { get; }
        string Description { get; }
        string ChasisNumber { get; }
    }
}
