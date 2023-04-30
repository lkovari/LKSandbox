using LKSandbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models
{
    internal class EngineServiceType : IEngineServiceType
    {
        public string Code { get; }

        public string Name { get; }

        public string Description { get; }

        public EngineServiceType(string code, string name, string desc)
        {
            Code = code;
            Name = name;
            Description = desc;
        }

        public decimal BuildDuration<T>(T buildDurationDataProvider) where T : IBuildDurationDataProvider
        {
            return buildDurationDataProvider.ProvideData().Days;
        }

        public bool HasApprovalToBuild<T>(T approvementDataProvider) where T : IApprovementDataProvider
        {
            return approvementDataProvider.ProvideData().IsApproved;
        }

        public decimal TotalCost<T>(T totalCostDataProvider) where T : ITotalCostDataProvider
        {
            return totalCostDataProvider.ProvideData().TotalCost;
        }
    }
}
