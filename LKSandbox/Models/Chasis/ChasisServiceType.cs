using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Chasis;

namespace LKSandbox.Models.Chasis
{
    internal class ChasisServiceType : IChasisServiceType
    {
        public string Name { get; }

        public string Description { get; }

        public string ChasisNumber { get; }

        public ChasisServiceType(string name, string desc, string chasisNum)
        {
            Name = name;
            Description = desc;
            ChasisNumber = chasisNum;
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
