using LKSandbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models
{
    internal class ChasisServiceType : IChasisServiceType
    {
        public string Name => "Chasis 1";

        public string Description => "Chasis 1 description";

        public string ChasisNumber => "CH-38934789";

        public decimal BuildDuration<T>(T buildDurationDataProvider) where T : IBuildDurationDataProvider
        {
            throw new NotImplementedException();
        }

        public bool HasApprovalToBuild<T>(T approvementDataProvider) where T : IApprovementDataProvider
        {
            throw new NotImplementedException();
        }

        public decimal TotalCost<T>(T totalCostDataProvider) where T : ITotalCostDataProvider
        {
            throw new NotImplementedException();
        }
    }
}
