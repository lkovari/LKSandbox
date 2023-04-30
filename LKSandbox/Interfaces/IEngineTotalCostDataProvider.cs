using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces
{
    internal interface IEngineTotalCostDataProvider : ITotalCostDataProvider
    {
        DateOnly Installation { get; }
    }
}
