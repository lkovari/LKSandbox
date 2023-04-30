using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Chasis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models.Chasis
{
    internal class ChasisApprovementDataProvider : IChasisApprovementDataProvider
    {
        public DateOnly Approvement { get; }

        public ChasisApprovementDataProvider(DateOnly date)
        {
            Approvement = date;
        }

        public IApprovementData ProvideData()
        {
            return new ApprovementData(new DateOnly(), false);
        }
    }
}
