using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IBuildDurationData
    {
        string Name { get; }
        DateOnly BuildDate { get; }
        decimal Days { get; }
    }
}
