using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models.Engine
{
    internal class EngineTotalCostDataProvider : IEngineTotalCostDataProvider
    {
        public DateOnly Installation { get; }

        public EngineTotalCostDataProvider(DateOnly date)
        {
            Installation = date;
        }

        public ITotalCostData ProvideData()
        {
            return new TotalCostData(19651966);
        }
    }
}
