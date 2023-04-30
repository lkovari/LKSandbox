using LKSandbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models
{
    internal class EngineApprovementDataProvider : IEngineApprovementDataProvider
    {
        public DateOnly Approvement { get; }

        public EngineApprovementDataProvider(DateOnly date)
        {
            Approvement = date;
        }

        public IApprovementData ProvideData()
        {
            return new ApprovementData(new DateOnly(), true);
        }
    }
}
