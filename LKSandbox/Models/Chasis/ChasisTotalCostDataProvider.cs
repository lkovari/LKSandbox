using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Chasis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models.Chasis
{
    internal class ChasisTotalCostDataProvider : IChasisTotalCostDataProvider
    {
        public DateOnly Installation { get; }

        public ChasisTotalCostDataProvider(DateOnly date)
        {
            Installation = date;
        }

        public ITotalCostData ProvideData()
        {
            return new TotalCostData(19661965);
        }
    }
}
