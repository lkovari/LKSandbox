﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisTotalCostDataProvider : ITotalCostDataProvider
    {
        DateOnly Installation { get; }
    }
}
